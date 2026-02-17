using Microsoft.EntityFrameworkCore;
using HelloWorldApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
 options.UseSqlServer("Server=localhost,1433;Database=BonJourDB1;User Id=sa;Password=Estiam@2026_2;TrustServerCertificate=True;"));




var app = builder.Build();
app.MapGet("/hello", () => "Bonjour le Monde!");


app.MapGet("/servicerequests", async (AppDbContext db) => 
 await db.ServiceRequests.ToListAsync());




app.Run();
