using GroceryBuddy.WebAPI.Infrastructure;

namespace GroceryBuddy.WebAPI.Domain;

public interface IGroceryService
{
    Task<List<Grocery>> GetGroceryList();
    Task<Grocery> GetGroceryById(string id);
    Task<Grocery> Create(Grocery grocery);
    Task<Grocery> Update(Grocery grocery);
    Task DeleteGroceryById(string id);
}
internal class GroceryService : IGroceryService
{
    private readonly IGroceryRepository _groceryRepository;

    public GroceryService(IGroceryRepository groceryRepository)
        => _groceryRepository = groceryRepository;

    public async Task<List<Grocery>> GetGroceryList()
        => await _groceryRepository.Get();

    public async Task<Grocery> GetGroceryById(string id)
        => await _groceryRepository.GetById(id);

    public async Task<Grocery> Create(Grocery grocery)
        => await _groceryRepository.Insert(grocery);

    public async Task<Grocery> Update(Grocery grocery)
        => await _groceryRepository.Update(grocery);

    public async Task DeleteGroceryById(string id)
        => await _groceryRepository.Delete(id);
}
