using d100_TTRPG.Client.Pages;
using d100_TTRPG.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

// Add controllers to expose API endpoints
builder.Services.AddControllers();

// Ensure HttpClient is available for interactive components (server prerender / server render)
// Register a named client with a sensible default BaseAddress. Override via configuration key "ServerBaseAddress".
builder.Services.AddHttpClient("Server", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ServerBaseAddress"] ?? "https://localhost:5001/");
});
builder.Services.AddScoped(sp => sp.GetRequiredService<System.Net.Http.IHttpClientFactory>().CreateClient("Server"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
// Map API controllers
app.MapControllers();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(d100_TTRPG.Client._Imports).Assembly);

app.Run();
