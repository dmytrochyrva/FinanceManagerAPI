using FinanceManagerAPI.Models;

namespace FinanceManagerAPI.Services.Interfaces;

public interface IOperationsService {
  Task<IList<Operation>> GetOperations();
  Task<Operation?> GetOperationById(int Id);
}