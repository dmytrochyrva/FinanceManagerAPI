namespace FinanceManager.Database.Services;

using Microsoft.EntityFrameworkCore;

using FinanceManager.Database.Models;
using FinanceManager.Database.Context;
using FinanceManager.Database.Interfaces;

public class CategoriesService : ICategoriesService {
  private readonly FinanceManagerContext _context;

  public CategoriesService(FinanceManagerContext context)
  {
    _context = context;
  }

  public async Task<IList<Category>> GetCategories() {
    var results = await _context.Categories.ToListAsync();

    return results;
  }

  public async Task<Category?> GetCategoryById(int categoryId) {
    return await _context.Categories.Where(Category => Category.Id == categoryId).FirstAsync();
  }
}