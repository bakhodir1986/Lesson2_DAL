using DataAccessLayerEF.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

builder.Services.AddSingleton<ITicketingContext, TicketingContext>();

builder.Services.AddSingleton<ITicketingRepository, TicketingRepository>();

builder.Services.AddDbContext<TicketingContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("TicketingContext")));

app.Run();

