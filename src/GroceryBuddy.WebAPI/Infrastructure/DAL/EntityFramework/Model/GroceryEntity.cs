namespace GroceryBuddy.WebAPI.Infrastructure.DAL.EntityFramework.Model;

public class GroceryEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Description { get; set; } = string.Empty;
}
