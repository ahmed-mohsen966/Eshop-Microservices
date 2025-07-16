namespace Catalog.API.Models;

public class Product : BaseEntity
{
    public string Name { get; private set; } = default!;
    public string Description { get; private set; } = default!;
    public List<string> Category { get; set; } = new();
    public string ImageFile { get; set; } = default!;
    public decimal Price { get; set; }
}
