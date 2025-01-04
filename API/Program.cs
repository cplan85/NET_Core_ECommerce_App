var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//before services

var app = builder.Build();

//After middleware

// Configure the HTTP request pipeline.
app.MapControllers();

app.Run();
