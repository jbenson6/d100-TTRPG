using System.Diagnostics;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace d100_TTRPG.Services;

public class UpdateService
{
    private const string Repository =
        "https://api.github.com/repos/jbenson6/d100-TTRPG";

    private readonly HttpClient httpClient;

    public bool UpdateAvailable { get; private set; }

    public string? LatestVersion { get; private set; }

    public string? DownloadUrl { get; private set; }

    public bool IsChecking { get; private set; }

    public UpdateService(HttpClient httpClient)
    {
        this.httpClient = httpClient;

        this.httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
            "d100-TTRPG-Updater");
    }

    public async Task CheckForUpdateAsync()
    {
        if (IsChecking)
        {
            return;
        }

        IsChecking = true;

        try
        {
            GitHubRelease? release =
                await httpClient.GetFromJsonAsync<GitHubRelease>(
                    $"{Repository}/releases/latest");

            if (release == null)
            {
                return;
            }

            LatestVersion =
                release.TagName.TrimStart('v');

            if (!Version.TryParse(
                    LatestVersion,
                    out Version? latestVersion))
            {
                return;
            }

            if (!Version.TryParse(
                    AppVersion.Current,
                    out Version? currentVersion))
            {
                return;
            }

            if (latestVersion > currentVersion)
            {
                UpdateAvailable = true;

                GitHubAsset? asset =
                    release.Assets?
                        .FirstOrDefault(a =>
                            a.Name.EndsWith(
                                ".zip",
                                StringComparison.OrdinalIgnoreCase));

                DownloadUrl = asset?.BrowserDownloadUrl;
            }
        }
        catch
        {
            // Update checking should never prevent the application
            // from running if GitHub is unavailable.
        }
        finally
        {
            IsChecking = false;
        }
    }

    public async Task<bool> InstallUpdateAsync()
    {
        if (!UpdateAvailable ||
            string.IsNullOrWhiteSpace(DownloadUrl))
        {
            return false;
        }

        try
        {
            string tempZip =
                Path.Combine(
                    Path.GetTempPath(),
                    "d100-TTRPG-update.zip");

            await using Stream source =
                await httpClient.GetStreamAsync(DownloadUrl);

            await using FileStream destination =
                File.Create(tempZip);

            await source.CopyToAsync(destination);

            string? applicationDirectory =
                AppContext.BaseDirectory;

            if (string.IsNullOrWhiteSpace(
                    applicationDirectory))
            {
                return false;
            }

            string updaterPath =
                Path.Combine(
                    applicationDirectory,
                    "d100 TTRPG.Updater.exe");

            if (!File.Exists(updaterPath))
            {
                return false;
            }

            Process.Start(new ProcessStartInfo
            {
                FileName = updaterPath,
                Arguments =
                    $"\"{tempZip}\" \"{applicationDirectory}\"",
                WorkingDirectory =
                    applicationDirectory,
                UseShellExecute = true
            });

            Environment.Exit(0);

            return true;
        }
        catch
        {
            return false;
        }
    }

    private class GitHubRelease
    {
        [JsonPropertyName("tag_name")]
        public string? TagName { get; set; }

        [JsonPropertyName("assets")]
        public List<GitHubAsset>? Assets { get; set; }
    }

    private class GitHubAsset
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("browser_download_url")]
        public string? BrowserDownloadUrl { get; set; }
    }
}