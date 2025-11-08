using E_Commerce.Shared.DataTransfererObjects;
using E_Commerce.Shared.DataTransfererObjects.Products;

namespace E_Commerce.ServiceAbstraction
{
    public interface IProductService
    {
        Task<ProductResponse?> GetByIdAsync(int id, CancellationToken cancellationToken=default);
        Task<PaginatedResult<ProductResponse>> GetProductsAsync(ProductQueryParameters parameters, CancellationToken cancellationToken =default);

        Task<IEnumerable<BrandResponse>> GetBrandsAsync(CancellationToken cancellationToken=default);
        Task<IEnumerable<TypeResponse>> GetTypesAsync(CancellationToken cancellationToken = default);

    }
}
