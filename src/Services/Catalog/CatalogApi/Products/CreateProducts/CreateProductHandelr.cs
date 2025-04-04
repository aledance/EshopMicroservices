namespace CatalogApi.Products.CreateProduct;


using BuildingBlocks.CQRS;
using CatalogApi.Modls;
using MediatR;
public record CreateProductCommand(Guid Id, string Name, List<string> Category, string Description, string ImageFile, decimal Price) :
    ICommand<CreateProductResult>, IRequest<CreateProductResult>;

    public record CreateProductResult(Guid Id);

// La clase 'CreateProductCommandHandelr' es interna, lo que significa que solo es accesible dentro del ensamblado actual.

internal class CreateProductCommandHandelr :
    ICommandHandler<CreateProductCommand, CreateProductResult>, IRequestHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Id = command.Id,
            Name = command.Name,
            Category = command.Category,
            Description = command.Description,
            ImageFile = command.ImageFile,
            Price = command.Price
        };

        // guardar la base de datos
        // devolver el resultado
        return new CreateProductResult(product.Id);
    }
}

