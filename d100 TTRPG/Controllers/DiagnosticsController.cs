using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace d100_TTRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiagnosticsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                var folder = Path.Combine(baseFolder, "d100_TTRPG", "Characters");

                var drive = Path.GetPathRoot(folder) ?? baseFolder;
                var driveInfo = new System.IO.DriveInfo(drive);
                long availableBytes = driveInfo.AvailableFreeSpace;

                bool folderExists = Directory.Exists(folder);
                string? writeTestError = null;
                bool canWrite = false;

                try
                {
                    Directory.CreateDirectory(folder);
                    var testFile = Path.Combine(folder, $"diag_test_{Guid.NewGuid()}.tmp");
                    System.IO.File.WriteAllText(testFile, "test");
                    System.IO.File.Delete(testFile);
                    canWrite = true;
                }
                catch (Exception ex)
                {
                    writeTestError = ex.Message;
                }

                var result = new
                {
                    SaveFolder = folder,
                    FolderExists = folderExists,
                    CanWrite = canWrite,
                    WriteTestError = writeTestError,
                    DriveRoot = drive,
                    AvailableFreeBytes = availableBytes,
                    ServerUser = Environment.UserName
                };

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}
