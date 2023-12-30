
using MediatR;
using Microsoft.EntityFrameworkCore;
using User.Application.Role;
using User.Application.UserRole;
using User.Application.Users;
using User.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRoleRepository,RoleRepository>();
builder.Services.AddScoped<IUserRepository,UserRepository>();
builder.Services.AddScoped<IUsersRoleRepository,UsersRoleRepository>();

builder.Services.AddMediatR(typeof(RoleRepository).Assembly);
builder.Services.AddMediatR(typeof(UserRepository).Assembly);
builder.Services.AddMediatR(typeof(UsersRoleRepository).Assembly);
builder.Services.AddDbContext<DBC>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
     b => b.MigrationsAssembly("User.API")));
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
