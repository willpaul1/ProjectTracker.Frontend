using ProjectTracker.Frontend.Clients;
using ProjectTracker.Frontend.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();

var projectTrackerApiUrl = builder.Configuration["ProjectTrackerApiUrl"] ?? throw new Exception("ProjectTrackerApiUrl is required");

builder.Services.AddHttpClient<ProjectsClient>(client => client.BaseAddress = new Uri(projectTrackerApiUrl));
builder.Services.AddHttpClient<LanguagesClient>(client => client.BaseAddress = new Uri(projectTrackerApiUrl));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();

app.UseStaticFiles();
//when working with forms, we need to add this
app.UseAntiforgery();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
