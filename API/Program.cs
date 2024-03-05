using API.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
    // .AddJsonOptions(options =>
    // {
    //     // options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
    // });

builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors();
builder.Services.AddAutoMapper(typeof(DataContext));

var app = builder.Build();

app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));

app.UseRouting(); 

app.UseAuthorization();

app.UseHttpsRedirection(); 

app.MapControllers();

app.Run();
