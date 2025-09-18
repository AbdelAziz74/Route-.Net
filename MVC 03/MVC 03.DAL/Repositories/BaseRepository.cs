using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_03.DAL.Context;

namespace MVC_03.DAL.Repositories
{
    public class BaseRepository<TEntity>(CompanyDbContext context) : IRepository<TEntity> where TEntity : class
    {

    }
}
