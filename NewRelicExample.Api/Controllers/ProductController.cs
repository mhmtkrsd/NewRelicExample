using Microsoft.AspNetCore.Mvc;
using NewRelicExample.Repository;
using NewRelicExample.Repository.Entities;

namespace NewRelicExample.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly NewRelicExampleDbContext _dbContext;

    public ProductController(NewRelicExampleDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    [HttpGet]
    public virtual List<Product> List()
    {
        return _dbContext.Products.ToList();
    }
}