using BuildingBlocks.CQRS.Command;
using Catalog.API.Models;

namespace Catalog.API.Products.Commands.CreateProduct;

public record CreateProductCommand(string Name,List<string> Category,string Description
    ,string Imagefile, decimal Price) :ICommand<CreateProductResult>;
public record CreateProductResult(Guid Id);

internal class Handler : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        var product = Product.init(command.Name,command.Description,command.Category,command.Imagefile,command.Price);

        return new CreateProductResult(Guid.NewGuid());
    }
}
