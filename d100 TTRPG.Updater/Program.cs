using System.Diagnostics;
using System.IO.Compression;

if (args.Length < 2)
    return;

string zipPath = args[0].Trim('"');
string applicationDirectory = args[1].Trim('"');

string applicationExe = Path.Combine(
    applicationDirectory,
    "d100_TTRPG.exe");

try
{
    // Wait for the main application to completely exit.
    for (int i = 0; i < 60; i++)
    {
        if (!IsApplicationRunning())
            break;

        await Task.Delay(500);
    }

    // Give Windows time to release file handles.
    await Task.Delay(1000);

    string tempDirectory = Path.Combine(
        Path.GetTempPath(),
        "d100-TTRPG-update-" +
        Guid.NewGuid().ToString("N"));

    Directory.CreateDirectory(tempDirectory);

    // Extract the downloaded release.
    ZipFile.ExtractToDirectory(
        zipPath,
        tempDirectory);

    // Copy the new release over the existing installation.
    // Existing files are overwritten, but nothing outside
    // the published application is touched.
    CopyDirectory(
        tempDirectory,
        applicationDirectory);

    // Clean up temporary files.
    try
    {
        File.Delete(zipPath);
        Directory.Delete(tempDirectory, true);
    }
    catch
    {
        // Cleanup failure is not fatal.
    }

    // Start the updated application.
    Process.Start(new ProcessStartInfo
    {
        FileName = applicationExe,
        WorkingDirectory = applicationDirectory,
        UseShellExecute = true
    });
}
catch (Exception ex)
{
    string errorFile = Path.Combine(
        Path.GetTempPath(),
        "d100-TTRPG-update-error.txt");

    File.WriteAllText(
        errorFile,
        ex.ToString());
}

bool IsApplicationRunning()
{
    string processName =
        Path.GetFileNameWithoutExtension(applicationExe);

    return Process.GetProcessesByName(processName).Length > 0;
}

void CopyDirectory(
    string sourceDirectory,
    string destinationDirectory)
{
    Directory.CreateDirectory(destinationDirectory);

    foreach (string file in Directory.GetFiles(sourceDirectory))
    {
        string destinationFile = Path.Combine(
            destinationDirectory,
            Path.GetFileName(file));

        // Never overwrite the updater while it is running.
        if (Path.GetFullPath(destinationFile)
            .Equals(
                Path.GetFullPath(Environment.ProcessPath ?? ""),
                StringComparison.OrdinalIgnoreCase))
        {
            continue;
        }

        File.Copy(
            file,
            destinationFile,
            true);
    }

    foreach (string directory in Directory.GetDirectories(sourceDirectory))
    {
        string destinationSubdirectory = Path.Combine(
            destinationDirectory,
            Path.GetFileName(directory));

        CopyDirectory(
            directory,
            destinationSubdirectory);
    }
}