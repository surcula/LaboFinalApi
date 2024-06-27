using LaboFinalAPIBLL.Interfaces.Repositories;
using LaboFinalAPIBLL.Interfaces.Services;
using LaboFinalAPIBLL.Services;
using LaboFinalAPIDAL;
using LaboFinalAPIDAL.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<DDBContext>();


builder.Services.AddScoped<IFeatsRepository,FeatRepo>();
builder.Services.AddScoped<IFeatsService, FeatsService>();

builder.Services.AddScoped<IClassesRepository, ClassRepo>();
builder.Services.AddScoped<IClassesService, ClassService>();

builder.Services.AddScoped<ISpellRepository, SpellRepo>();
builder.Services.AddScoped<ISpellService, SpellService>();

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
