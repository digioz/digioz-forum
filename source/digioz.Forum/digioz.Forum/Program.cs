using digioz.Forum.Data;
using digioz.Forum.Filters;
using digioz.Forum.Logging;
using digioz.Forum.Models;
using digioz.Forum.Services;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configure DB logger provider from configuration (appsettings.json: DbLogger)
builder.Services.Configure<DbLoggerOptions>(builder.Configuration.GetSection("DbLogger"));
builder.Logging.AddDbLogger();

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContext<DigiozForumContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()   // Add this line to enable roles
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Add custom services
builder.Services.AddScoped<IForumConfigService, ForumConfigService>();
builder.Services.AddScoped<IForumSessionService, ForumSessionService>();
builder.Services.AddScoped<IForumUserService, ForumUserService>();
builder.Services.AddScoped<IForumService, ForumService>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IUserRoleService, UserRoleService>();
builder.Services.AddScoped<IForumPostService, ForumPostService>();
builder.Services.AddScoped<IForumPermissionService, ForumPermissionService>();
builder.Services.AddScoped<IForumTopicService, ForumTopicService>();
builder.Services.AddScoped<IForumLogService, ForumLogService>();

// IHttpContextAccessor for filters
builder.Services.AddHttpContextAccessor();

// Register page logger filter
builder.Services.AddScoped<PageLoggerFilter>();

builder.Services.AddRazorPages(options =>
{
    // Global page filter to log page loads
    options.Conventions.ConfigureFilter(new PageLoggerFilterFactory());
});

builder.Services.AddSingleton<ILayoutService, LayoutService>();

// Login Options
builder.Services.Configure<IdentityOptions>(options =>
{
    // Default Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(120);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = false;
    // Default Signin settings. 
    options.SignIn.RequireConfirmedAccount = false;
    options.SignIn.RequireConfirmedEmail = false;
    // Default Password settings.
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 8;
    options.Password.RequiredUniqueChars = 1;
    // Default User settings.
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true;
});

// Configure Cookie Options
builder.Services.ConfigureApplicationCookie(options =>
{
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.Cookie.Name = "DigiOzForumCookie";
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    options.LoginPath = "/Identity/Account/Login";
    options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
    options.SlidingExpiration = true;
});

// Add Session Service
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(240);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseSession();
app.MapRazorPages();

app.Run();
