using BuildingBlocks.CQRS;
using CatalogApi.Modls;


namespace Catalog.API.Products.CreateProduct;

public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
    : ICommand<CreateProductResult>, IRequest<CreateProductResult>; // Implement IRequest<CreateProductResult>
public record CreateProductResult(Guid Id);



internal class CreateProductCommandHandler

    : ICommandHandler<CreateProductCommand, CreateProductResult>, IRequestHandler<CreateProductCommand, CreateProductResult> // Implement IRequestHandler
{ 
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        //create Product entity from command object
        //save to database
        //return CreateProductResult result               

        var product = new Product
        {
            Name = command.Name,
            Category = command.Category,
            Description = command.Description,
            ImageFile = command.ImageFile,
            Price = command.Price
        };

        //return result
        return new CreateProductResult(product.Id);
    }
}
