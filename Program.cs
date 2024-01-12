using GutierrezFMiniChallengeTwoToFour_EndPoint.MiniChallengeOne;
using GutierrezFMiniChallengeTwoToFour_EndPoint.Servers.MINIChallengeOne;
using GutierrezFMiniChallengeTwoToFour_EndPoint.Servers.MINIChallengeOne.MiniChallengeFour;
using GutierrezFMiniChallengeTwoToFour_EndPoint.Servers.MINIChallengeOne.MiniChallengeOne;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMiniChallengeFourServices, MiniChallengeFourServices>();
builder.Services.AddScoped<IMiniChallengeThreeServices, MiniChallengeThreeService>();
builder.Services.AddScoped<IMiniChallengeServer, MiniChallengeOneServer>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
