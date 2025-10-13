
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Web.Controllers;
[ApiController]
[Route("api/[Controller]")] 
public class ProductsController : ControllerBase
{
    [Route("{id}")]
    [HttpGet]
    public ActionResult Get(int id)
    { 
        return Ok ( new Product { Id = id}); 
    }
    [HttpGet]
    public ActionResult GetAll(int id)
    {
        return Ok(new Product { });
    }

    [HttpPost]
    public ActionResult Create(Product product)
    {
        return Created("Test", product);
    }

    [HttpPut]
    public ActionResult Update(Product product)
    {
        return Ok(product);
    }

    [HttpDelete]
    public ActionResult Delete(int id)
    {
        return NoContent();
    }
        
}
public class Product
{
    public int Id { get; set; } = 1;
    public string Name { get; set; } = "Sample Product";
}

