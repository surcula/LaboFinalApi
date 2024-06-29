using LaboFinalAPIBLL.Interfaces.Repositories;
using LaboFinalAPIBLL.Interfaces.Services;
using LaboFinalAPIBLL.Services;
using LaboFinalAPIDAL;
using LaboFinalAPIDAL.Repositories;
using LaboFinalAPIDomain.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<DDBContext>();

builder.Services.AddScoped<IBackgroundRepository, BackgroundRepo>();
builder.Services.AddScoped<IBackgroundService, LaboFinalAPIBLL.Services.BackgroundService>();

builder.Services.AddScoped<IFeatsRepository,FeatRepo>();
builder.Services.AddScoped<IFeatsService, FeatsService>();

builder.Services.AddScoped<IClassesRepository, ClassRepo>();
builder.Services.AddScoped<IClassesService, ClassService>();

builder.Services.AddScoped<ISpellRepository, SpellRepo>();
builder.Services.AddScoped<ISpellService, SpellService>();

builder.Services.AddScoped<ILanguageRepository, LanguageRepo>();
builder.Services.AddScoped<ILanguageService, LanguageService>();

builder.Services.AddScoped<IBackgroundRepository, BackgroundRepo>();
builder.Services.AddScoped<IBackgroundService, LaboFinalAPIBLL.Services.BackgroundService>();

builder.Services.AddScoped<IFeatsRepository, FeatRepo>();
builder.Services.AddScoped<IFeatsService, FeatsService>();

builder.Services.AddScoped<ISpellRepository, SpellRepo>();
builder.Services.AddScoped<ISpellService, SpellService>();

builder.Services.AddScoped<IRacesRepository, RaceRepo>();
builder.Services.AddScoped<IRacesService, RaceService>();

builder.Services.AddScoped<IRaceLanguagesRepository, RaceLanguageRepo>();
builder.Services.AddScoped<IRaceLanguagesService, RaceLanguageService>();



var app = builder.Build();



if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
