namespace E_Commerce.Shared.DataTransfererObjects.Products;

public class ProductQueryParameters
{
    private const int MAXPAGESIZE = 10;
    private const int DEFALUTPAGESIZE = 5;
    public int? BrandId { get; set; }
    public int? TypeId { get; set; }
    public string? Search { get; set; }
    public ProductSortingOptions Sort { get; set; }
    private int pageSize = DEFALUTPAGESIZE;
    public int PageSize 
    { 
        get => pageSize; 
        set => pageSize = value > MAXPAGESIZE ? MAXPAGESIZE : 
            value < DEFALUTPAGESIZE ? DEFALUTPAGESIZE : value; 
    }
    public int PageIndex { get; set; } = 1; 



}
public enum ProductSortingOptions
{
    NameAscending = 1,
    NameDscending = 2,
    PriceAscending = 3,
    PriceDscending = 4
}