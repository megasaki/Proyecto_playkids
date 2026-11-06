using Microsoft.EntityFrameworkCore;
using playkidsAPI.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<DbContextSistema>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionPlayKids")));

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