


using Catalog.API.Products.CreateProduct;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var assembly = typeof(Program).Assembly;
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblyContaining<CreateProductCommandHandler>();
    
});

builder.Services.AddCarter();


var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapCarter();





app.Run();
