using System.Threading.Tasks;
using E_Commerce.ServiceAbstraction;
using E_Commerce.Shared.DataTransfererObjects.Products;
using Microsoft.AspNetCore.Mvc;
namespace E_Commerce.Presentation.API.Controllers;

public class ProductsController(IProductService service)
    : APIBaseController
{
    // Get All (filtration, search, order, pagination)
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductResponse>>> GetProducts(CancellationToken cancellationToken = default)
    {
        var response = await service.GetProductsAsync(cancellationToken);
        return Ok(response);
    }
    // Get By Id(int id)
    [HttpGet("{id}")]
    public async Task<ActionResult<ProductResponse>> Get(int id, CancellationToken cancellationToken = default)
    {
        var response = await service.GetByIdAsync(id, cancellationToken);
        return Ok(response);
    }
    // GetBrands
    [HttpGet("Brands")]

    public async Task<ActionResult<IEnumerable<BrandResponse>>> GetBrands(CancellationToken cancellationToken = default)
    {
        var response = await service.GetBrandsAsync(cancellationToken);
        return Ok(response);
    }
    // GetTypes
    [HttpGet("Types")]

    public async Task<ActionResult<IEnumerable<TypeResponse>>> GetTypes(CancellationToken cancellationToken = default)
    {
        var response = await service.GetTypesAsync(cancellationToken); 
        return Ok(response);
    }
} 