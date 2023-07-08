namespace FinanceManager.Database.Interfaces;

using FinanceManager.Database.Models;

public interface IOperationsService {
  Task<IList<Operation>> GetOperations();
  Task<Operation?> GetOperationById(int operationId);
}