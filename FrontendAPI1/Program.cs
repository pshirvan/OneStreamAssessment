using Microsoft.AspNetCore.Authentication.JwtBearer;
using FrontEndAPI.Services;
using FrontendAPI.Data;
using Microsoft.EntityFrameworkCore;
using FrontendAPI.Services;
using System.Xml.Linq;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("InMemoryDb"));

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()  // Add the Blazor app URL
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Configure JWT Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

// Uncomment to enable authentication and authorization
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient(); // For API2 and API3 calls
builder.Services.AddScoped<IAPIService, APIService>(); // Custom service for API calls
builder.Services.AddScoped<ITokenService, TokenService>(); // Custom service for security token generation
builder.Services.AddHttpClient<IBackendService, BackendService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
// app.UseAuthentication();  // Uncomment to enable API security
// app.UseAuthorization();   // Uncomment to enable API security
app.MapControllers();
app.Run();
