using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentTeacherDemo.Data.Context;
using StudentTeacherDemo.Data.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddIdentity<User, IdentityRole>(o =>
{
    o.Password.RequireDigit = false;
    o.Password.RequireLowercase = false;
    o.Password.RequireUppercase = false;
    o.Password.RequireNonAlphanumeric = false;
    o.User.RequireUniqueEmail = true;
})
       .AddEntityFrameworkStores<RepositoryContext>()
       .AddDefaultTokenProviders();


builder.Services.AddAuthentication();

builder.Services.AddDbContext<RepositoryContext>(options =>

options.UseSqlServer(builder.Configuration.GetConnectionString("ConnStr")));



var app = builder.Build();



app.UseAuthentication();
app.UseAuthorization();


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
