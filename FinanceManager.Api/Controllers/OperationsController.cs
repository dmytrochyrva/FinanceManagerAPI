namespace FinanceManager.Api.Controllers;

// Libraries Usings
using Microsoft.AspNetCore.Mvc;

// Project Usings
using FinanceManager.Database.Models;
using FinanceManager.Database.Interfaces;


[ApiController]
[Route("api/[controller]")]
public class OperationsController : ControllerBase
{
    private readonly ILogger<OperationsController> _logger;
    private readonly IOperationsService _operationsService;

    public OperationsController(ILogger<OperationsController> logger, IOperationsService operationsService)
    {
        _logger = logger;
        _operationsService = operationsService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Operation>>> Get()
    {
        var result = await _operationsService.GetOperations();

        if(result != null) {
            return Ok(result);
        }

        return NotFound();
    }

    [HttpGet]
    [Route("{operationId}")]
    public async Task<ActionResult<IEnumerable<Operation>>> GetById(int operationId)
    {
        var result = await _operationsService.GetOperationById(operationId);

        if(result != null) {
            return Ok(result);
        }

        return NotFound();
    }
}
