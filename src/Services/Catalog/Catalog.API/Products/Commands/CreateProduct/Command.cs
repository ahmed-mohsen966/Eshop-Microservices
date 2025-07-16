namespace Catalog.API.Products.Commands.CreateProduct;


public record CreateProductRequest(string name, List<string> category, string description, string imageFile, decimal price);
public record CreateProductResponse(Guid Id);
