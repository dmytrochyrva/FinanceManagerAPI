using Microsoft.AspNetCore.Mvc;
using FinanceManagerAPI.Models;
using FinanceManagerAPI.Services.Interfaces;

namespace FinanceManagerAPI.Controllers;

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
    [Route("{id}")]
    public async Task<ActionResult<IEnumerable<Operation>>> GetById(int id)
    {
        var result = await _operationsService.GetOperationById(id);

        if(result != null) {
            return Ok(result);
        }

        return NotFound();
    }
}
