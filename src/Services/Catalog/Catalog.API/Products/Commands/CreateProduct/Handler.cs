using MediatR;

namespace Catalog.API.Products.Commands.CreateProduct;

public record CreateProductCommand(string Name,List<string> Category,string Description
    ,string Imagefile, decimal Price) :IRequest<CreateProductResult>;
public record CreateProductResult(Guid Id);

internal class Handler : IRequestHandler<CreateProductCommand, CreateProductResult>
{
    public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
