using CommandsService.AsyncDataServices;
using CommandsService.Data;
using CommandsService.EventProcessing;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("InMem"));
    
builder.Services.AddControllers();
builder.Services.AddHostedService<MessageBusSubscriber>();
builder.Services.AddSingleton<IEventProcessor, EventProcessor>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<ICommandRepo, CommandRepo>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
