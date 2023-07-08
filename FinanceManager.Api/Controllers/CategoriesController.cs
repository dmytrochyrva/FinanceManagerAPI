namespace FinanceManager.Api.Controllers;

using Microsoft.AspNetCore.Mvc;

using FinanceManager.Database.Models;
using FinanceManager.Database.Interfaces;


[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ILogger<CategoriesController> _logger;
    private readonly ICategoriesService _categoriesService;

    public CategoriesController(ILogger<CategoriesController> logger, ICategoriesService categoriesService)
    {
        _logger = logger;
        _categoriesService = categoriesService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Category>>> Get()
    {
        var result = await _categoriesService.GetCategories();

        if(result != null) {
            return Ok(result);
        }

        return NotFound();
    }

    [HttpGet]
    [Route("{categoryId}")]
    public async Task<ActionResult<IEnumerable<Category>>> GetById(int categoryId)
    {
        var result = await _categoriesService.GetCategoryById(categoryId);

        if(result != null) {
            return Ok(result);
        }

        return NotFound();
    }
}
