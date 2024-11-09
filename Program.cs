using Microsoft.AspNetCore.Http.Json;
using NascarCalendar.Components;
using NascarCalendar.Services;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add Bootstrap
builder.Services.AddBlazorBootstrap();

// Add my services
builder.Services.AddSingleton<ICalendarService, CalendarService>();
builder.Services.AddSingleton<ISeriesService, SeriesService>();
builder.Services.AddSingleton<IErrorService, ErrorService>();
builder.Services.AddHttpClient<CalendarService>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//Configure JSON parsing options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStatusCodePagesWithReExecute("/404");

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();



app.Run();
