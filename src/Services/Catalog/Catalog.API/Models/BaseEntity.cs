namespace Catalog.API.Models;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedOn{ get; set; }
    public string CreatedBy { get; set; } = default!;
    public DateTime UpdaetedOn { get; set; }
    public string UpdatedBy { get; set; } = default!;
    public bool IsDeleted { get; set; }
}
