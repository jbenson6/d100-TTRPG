using d100_TTRPG.Shared.Data_Objects;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace d100_TTRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharactersController : ControllerBase
    {
        private readonly ILogger<CharactersController> _logger;
        private static string? _saveBasePath;

        public CharactersController(ILogger<CharactersController> logger)
        {
            _logger = logger;
        }

        private static string GetCharactersFolder()
        {
            string baseFolder;

            if (!string.IsNullOrWhiteSpace(_saveBasePath))
            {
                baseFolder = _saveBasePath;
            }
            else
            {
                baseFolder = Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData);
            }

            var folder = Path.Combine(
                baseFolder,
                "d100_TTRPG",
                "Characters");

            Directory.CreateDirectory(folder);

            return folder;
        }

        // ============================================================
        // SAVE PATH
        // ============================================================

        [HttpGet("savepath")]
        public IActionResult GetSavePath()
        {
            string baseFolder =
                _saveBasePath ??
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData);

            var folder = Path.Combine(
                baseFolder,
                "d100_TTRPG",
                "Characters");

            return Ok(new
            {
                baseFolder,
                folder
            });
        }

        public class SavePathDto
        {
            public string? BasePath { get; set; }
        }

        [HttpPost("savepath")]
        public IActionResult SetSavePath(
            [FromBody] SavePathDto dto)
        {
            if (dto == null ||
                string.IsNullOrWhiteSpace(dto.BasePath))
            {
                return BadRequest("Missing base path");
            }

            try
            {
                var baseFolder = dto.BasePath;

                var folder = Path.Combine(
                    baseFolder,
                    "d100_TTRPG",
                    "Characters");

                Directory.CreateDirectory(folder);

                _saveBasePath = baseFolder;

                return Ok(new
                {
                    baseFolder = _saveBasePath,
                    folder
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Failed to set save path to {path}",
                    dto.BasePath);

                return StatusCode(
                    500,
                    new
                    {
                        error = ex.Message
                    });
            }
        }

        [HttpDelete("savepath")]
        public IActionResult ResetSavePath()
        {
            _saveBasePath = null;

            var baseFolder =
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData);

            var folder = Path.Combine(
                baseFolder,
                "d100_TTRPG",
                "Characters");

            Directory.CreateDirectory(folder);

            return Ok(new
            {
                baseFolder,
                folder
            });
        }

        // ============================================================
        // FILE NAME
        // ============================================================

        private static string SanitizeFileName(string s)
        {
            foreach (var c in Path.GetInvalidFileNameChars())
            {
                s = s.Replace(c, '_');
            }

            return s.Replace(' ', '_');
        }

        // ============================================================
        // LIST
        // ============================================================

        [HttpGet]
        public IActionResult List()
        {
            var folder = GetCharactersFolder();

            var files = Directory
                .EnumerateFiles(folder, "*.json")
                .Select(Path.GetFileName)
                .OrderBy(n => n)
                .ToList();

            return Ok(files);
        }

        // ============================================================
        // LOAD
        // ============================================================

        [HttpGet("{fileName}")]
        public IActionResult Get(string fileName)
        {
            var folder = GetCharactersFolder();

            // Prevent path traversal.
            fileName = Path.GetFileName(fileName);

            var path = Path.Combine(folder, fileName);

            if (!System.IO.File.Exists(path))
            {
                return NotFound();
            }

            try
            {
                var json = System.IO.File.ReadAllText(path);

                var character =
                    JsonSerializer.Deserialize<ClientCharacterDto>(
                        json,
                        new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

                if (character == null)
                {
                    return BadRequest("Invalid character file");
                }

                return Ok(character);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Failed to load character from {path}",
                    path);

                return BadRequest("Invalid file");
            }
        }

        // ============================================================
        // SAVE
        // ============================================================

        [HttpPost]
        public IActionResult Save([FromBody] ClientCharacterDto dto)
        {
            if (dto == null ||
                string.IsNullOrWhiteSpace(dto.Name))
            {
                return BadRequest("Missing character name");
            }

            var folder = GetCharactersFolder();

            var filename = SanitizeFileName(
                $"{dto.Location}_{dto.Race}_{dto.Name}");

            if (!filename.EndsWith(
                    ".json",
                    StringComparison.OrdinalIgnoreCase))
            {
                filename += ".json";
            }

            var path = Path.Combine(folder, filename);

            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                var json =
                    JsonSerializer.Serialize(dto, options);

                System.IO.File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Failed to save character to {path}",
                    path);

                return StatusCode(
                    500,
                    new
                    {
                        error = ex.Message,
                        path
                    });
            }

            _logger.LogInformation(
                "Character saved to {path}",
                path);

            return CreatedAtAction(
                nameof(Get),
                new
                {
                    fileName = Path.GetFileName(path)
                },
                new
                {
                    file = Path.GetFileName(path),
                    path
                });
        }
    }
}