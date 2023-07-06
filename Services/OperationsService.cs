using FinanceManagerAPI.Models;
using FinanceManagerAPI.Context;
using FinanceManagerAPI.Services.Interfaces;

using Microsoft.EntityFrameworkCore;



namespace FinanceManagerAPI.Services;

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

  public async Task<Operation?> GetOperationById(int Id) {
    return await _context.Operations.Where(Operation => Operation.Id == Id).FirstAsync();
  }
}