using Microsoft.EntityFrameworkCore;
using ShiftSwap.Api.Data;
using ShiftSwap.Api.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options
        .UseNpgsql(
            builder.Configuration.GetConnectionString("DefaultConnection")
        )
        .UseSeeding((context, _) =>
        {
            var users = context.Set<User>();

            if (!users.Any())
            {
                users.AddRange(
                    new User
                    {
                        Name = "Karl",
                        Email = "karl@shiftswap.local",
                        Role = UserRole.Employee
                    },
                    new User
                    {
                        Name = "John",
                        Email = "john@shiftswap.local",
                        Role = UserRole.Employee
                    },
                    new User
                    {
                        Name = "Maria",
                        Email = "maria@shiftswap.local",
                        Role = UserRole.Manager
                    }


                );

                context.SaveChanges();

            }

            var shifts = context.Set<Shift>();

            if (!shifts.Any())
            {
                var karl = users.Single(user => user.Email == "karl@shiftswap.local");

                var john = users.Single(user => user.Email == "john@shiftswap.local");

                shifts.AddRange(
                    new Shift
                    {
                        Employee = karl,
                        ShiftDate = new DateOnly(2026, 8, 24),
                        StartTime = new TimeOnly(8, 0),
                        EndTime = new TimeOnly(16, 0)
                    },

                     new Shift
                     {
                         Employee = karl,
                         ShiftDate = new DateOnly(2026, 8, 25),
                         StartTime = new TimeOnly(8, 0),
                         EndTime = new TimeOnly(16, 0)
                     },

                    new Shift
                    {
                        Employee = john,
                        ShiftDate = new DateOnly(2026, 8, 24),
                        StartTime = new TimeOnly(9, 0),
                        EndTime = new TimeOnly(17, 0)
                    }
                );

                context.SaveChanges();


            }



        });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
