using d100_TTRPG;
using d100_TTRPG.Client.Pages;
using d100_TTRPG.Components;
using d100_TTRPG.Services;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddControllers();

builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<UpdateService>();

builder.Services.AddScoped(sp =>
{
    var accessor = sp.GetRequiredService<IHttpContextAccessor>();
    var request = accessor.HttpContext?.Request;

    if (request == null)
    {
        return new HttpClient();
    }

    return new HttpClient
    {
        BaseAddress = new Uri($"{request.Scheme}://{request.Host}/")
    };
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute(
    "/not-found",
    createScopeForStatusCodePages: true);

//app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();

app.MapControllers();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(
        typeof(d100_TTRPG.Client._Imports).Assembly);

GameDatabaseInitializer.Initialize();


// ---------------------------------------------------------
// Automatically open the application in the default browser
// when the published EXE is launched.
// ---------------------------------------------------------
if (!app.Environment.IsDevelopment())
{
    app.Lifetime.ApplicationStarted.Register(() =>
    {
        try
        {
            var url = app.Urls
                .FirstOrDefault(u =>
                    u.StartsWith(
                        "http://",
                        StringComparison.OrdinalIgnoreCase))
                ?? app.Urls.FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(url))
            {
                app.Logger.LogInformation(
                    "Opening application in browser: {Url}",
                    url);

                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            else
            {
                app.Logger.LogWarning(
                    "Application started, but no listening URL was found.");
            }
        }
        catch (Exception ex)
        {
            app.Logger.LogWarning(
                ex,
                "Unable to automatically open the application browser.");
        }
    });
}

app.Run();