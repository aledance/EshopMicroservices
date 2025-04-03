var builder = WebApplication.CreateBuilder(args);
// Add sercvices to the container.
var app = builder.Build();
//Configure the HTTP request pipeline.


app.Run();
