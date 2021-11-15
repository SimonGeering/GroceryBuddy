using GroceryBuddy.WebAPI.Domain;

namespace GroceryBuddy.WebAPI.Infrastructure.DAL;

public interface IGroceryRepository
{
    Task<List<Grocery>> Get();
    Task<Grocery> GetById(string id);
    Task<Grocery> Insert(Grocery grocery);
    Task<Grocery> Update(Grocery grocery);
    Task Delete(string id);
}
internal class GroceryRepository : IGroceryRepository
{
    public Task Delete(string id) => throw new NotImplementedException();
    public Task<List<Grocery>> Get() => throw new NotImplementedException();
    public Task<Grocery> GetById(string id) => throw new NotImplementedException();
    public Task<Grocery> Insert(Grocery grocery) => throw new NotImplementedException();
    public Task<Grocery> Update(Grocery grocery) => throw new NotImplementedException();
}
