using Application.ServiceImpl;
using ExamWebApplication.Contracts;
using ExamWebApplication.DataAccess;
using TeamWebApi.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<DataBaseContext>();
builder.Services.AddScoped<ITeamService, TeamServiceImpl>();
builder.Services.AddScoped<IPlayerService, PlayerServiceImpl>();
//builder.Services.AddScoped<IPlayerService, Player>();

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