using Microsoft.EntityFrameworkCore;
using E_Commerce.Persistence.Repositories;

namespace E_Commerce.Service.Specifications;

internal static class SpecificationEvaluator
{
    public static IQueryable<TEntity> ApplySpecification<TEntity>(this IQueryable<TEntity> inputQuery,
        ISpecification<TEntity> specification)
        where TEntity : class
    {
        var query = inputQuery;

        if (specification.Criteria is not null)
            query = query.Where(specification.Criteria);

        //foreach (var include in specification.Includes)
        //    query.Include(include);
        
        if (specification.OrderBy is not null)
            query = query.OrderBy(specification.OrderBy);
        else if (specification.OrderByDesc is not null)
            query = query.OrderByDescending(specification.OrderByDesc);

        query = specification.Includes
            .Aggregate(query, (query, include) => query.Include(include));

        if (specification.IsPaginated)
            query = query.Skip(specification.Skip).Take(specification.Take);

        return query;
    }
}