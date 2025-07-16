namespace Catalog.API.Models;

public class Product : BaseEntity
{
    public string Name { get; private set; } = default!;
    public string Description { get; private set; } = default!;
    public List<string> Category { get; set; } = new();
    public string ImageFile { get; set; } = default!;
    public decimal Price { get; set; }

    public Product()
    {
        
    }

    private Product(string name, string description, List<string> category, string imageFile, decimal price)
    {
        Name = name;
        Description = description;
        Category = category;
        ImageFile = imageFile;
        Price = price;
    }

    #region Factory Methods

    public static Product init(string name, string description, List<string> category, string imageFile, decimal price)
        => new Product(name,description,category,imageFile,price);

    #endregion
}
