
using Carter;
using Mapster;
using MediatR;

namespace CatalogApi.Products.CreateProducts;
    public record CreateProductRequest(Guid Id, string Name, List<string> Category, string Description, string ImageFile, decimal Price); 
    public record CreateProductResponse(Guid Id);
    
    public record CreateProductCommand(Guid Id, string Name, List<string> Category, string Description, string ImageFile, decimal Price) : IRequest<CreateProductResponse>;



public class CreateProductendpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/products", async (CreateProductRequest request, IMediator mediator) =>
        {
            var command = request.Adapt<CreateProductCommand>();
            app.MapPost("/products", async (CreateProductRequest request, IMediator mediator) =>
            {
                var command = request.Adapt<CreateProductCommand>();
                var result = await mediator.Send(command);
                var response = result.Adapt<CreateProductResponse>();
                return Results.Created($"/products/{response.Id}", response);
            });
              

        });
    }
}

    



