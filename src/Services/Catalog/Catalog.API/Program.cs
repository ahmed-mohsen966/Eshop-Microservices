
var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddCarter(
 new DependencyContextAssemblyCatalog(assemblies: typeof(Program).Assembly)
);
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

builder.Services.AddMarten(opts =>
{
    opts.Connection(builder.Configuration.GetConnectionString("Database")!);
}).UseLightweightSessions();



var app = builder.Build();

// Configure http request pipeline
app.MapCarter();

app.Run();
