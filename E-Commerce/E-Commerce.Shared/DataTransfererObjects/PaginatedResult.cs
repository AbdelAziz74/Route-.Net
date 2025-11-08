namespace E_Commerce.Shared.DataTransfererObjects;

public record PaginatedResult<TResult>(
    int PageIndex,
    int PageCount,
    int TotalCount,
    IEnumerable<TResult> Data
); 

