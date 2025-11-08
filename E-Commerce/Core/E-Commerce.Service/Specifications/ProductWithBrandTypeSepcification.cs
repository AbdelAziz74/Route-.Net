using System.Linq.Expressions;

namespace E_Commerce.Service.Specifications;

internal class ProductWithBrandTypeSepcification : BaseSpecification<Product>
{
    // Get All
    public ProductWithBrandTypeSepcification(ProductQueryParameters parameters)
        : base(CreateCriteria(parameters))
    {
        AddInclude(p => p.ProductBrand);
        AddInclude(p => p.ProductType);
        ApplyPagination(parameters.PageSize, parameters.PageIndex);
        Sort(parameters);
    }

    private void Sort(ProductQueryParameters parameters)
    {
        switch (parameters.Sort)
        {
            case ProductSortingOptions.NameAscending:
                AddOrderBy(p => p.Name);
                break;
            case ProductSortingOptions.NameDscending:
                AddOrderByDesc(p => p.Name);
                break;
            case ProductSortingOptions.PriceAscending:
                AddOrderBy(p => p.Price);
                break;
            case ProductSortingOptions.PriceDscending:
                AddOrderByDesc(p => p.Price);
                break;
            default:
                AddOrderBy(p => p.Name);
                break;
        }
    }

    private static Expression<Func<Product, bool>> CreateCriteria(ProductQueryParameters parameters)
    {
        return p => (!parameters.BrandId.HasValue || p.BrandId == parameters.BrandId.Value)
                 && (!parameters.TypeId.HasValue || p.TypeId == parameters.TypeId.Value)
                 && (string.IsNullOrWhiteSpace(parameters.Search) || p.Name.Contains(parameters.Search));
    } 

    public ProductWithBrandTypeSepcification(int id)
        : base(p => p.Id == id)
    {
        AddInclude(p => p.ProductBrand);
        AddInclude(p => p.ProductType);
    }
}
