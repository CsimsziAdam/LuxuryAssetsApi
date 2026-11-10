using LuxuryAssetsApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adatbázis kontextus regisztrálása (In-Memory adatbázis teszteléshez)
builder.Services.AddDbContext<LuxuryDbContext>(options =>
    options.UseInMemoryDatabase("LuxuryAssetsDb"));

// Szolgáltatások regisztrálása (Controller-ek támogatása)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

var app = builder.Build();

// HTTP kérések csővezetéke (Pipeline)
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Controller-ek útvonalainak leképezése
app.MapControllers();

app.Run();
