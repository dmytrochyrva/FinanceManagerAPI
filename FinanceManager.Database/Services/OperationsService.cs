namespace FinanceManager.Database.Services;

using Microsoft.EntityFrameworkCore;

using FinanceManager.Database.Models;
using FinanceManager.Database.Context;
using FinanceManager.Database.Interfaces;

public class OperationsService : IOperationsService {
  private readonly FinanceManagerContext _context;

  public OperationsService(FinanceManagerContext context)
  {
    _context = context;
  }

  public async Task<IList<Operation>> GetOperations() {
    var results = await _context.Operations.ToListAsync();

    return results;
  }

  public async Task<Operation?> GetOperationById(int operationId) {
    return await _context.Operations.Where(Operation => Operation.Id == operationId).FirstAsync();
  }
}