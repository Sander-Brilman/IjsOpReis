using IJsOpReis.Components;
using IJsOpReis.Data;
using IJsOpReis.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<AllowEditingService>();
builder.Services.AddQuickGridEntityFrameworkAdapter();

string connectionString = GetConnectionStringFromEnv(builder);
builder.Services.AddDbContextFactory<AppDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});

var app = builder.Build();

PerformDatabaseMigration(app);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.MapStaticAssets();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

static void PerformDatabaseMigration(WebApplication app)
{
    Console.WriteLine("Migrating database");
    using (var scope = app.Services.CreateScope())
    {
        IDbContextFactory<AppDbContext> dbContext = app.Services.GetRequiredService<IDbContextFactory<AppDbContext>>();
        dbContext.CreateDbContext().Database.Migrate();
    }
    Console.WriteLine("Finished migrating database");
}

static string GetConnectionStringFromEnv(WebApplicationBuilder builder)
{
    string password = builder.Configuration.GetValue<string>("DBPassword") ?? File.ReadAllText(builder.Configuration.GetValue<string>("DBPasswordFile")!)!;
    string connectionString = builder.Configuration.GetValue<string>("DBConnectionString")! + ";Password=" + password;
    return connectionString;
}