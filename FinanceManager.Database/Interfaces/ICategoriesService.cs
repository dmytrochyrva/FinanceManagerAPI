namespace FinanceManager.Database.Interfaces;

using FinanceManager.Database.Models;

public interface ICategoriesService {
  Task<IList<Category>> GetCategories();
  Task<Category?> GetCategoryById(int categoryId);
}