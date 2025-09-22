using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_03.DAL.Context;
using MVC_03.DAL.Entities;

namespace MVC_03.DAL.Repositories
{
    public class BaseRepository<TEntity>(CompanyDbContext context) : IRepository<TEntity> where TEntity : BaseEntity
    {
        private DbSet<TEntity> _TEntitys = context.TEntitys;
        public IEnumerable<TEntity> GetAll(bool trackChanges = false)
            => trackChanges
                ? _TEntitys.ToList()
                : _TEntitys.AsNoTracking().ToList();

        public TEntity? GetById(int id)
            => _TEntitys.Find(id);

        public int Add(TEntity TEntity)
        {
            _TEntitys.Add(TEntity);
            return context.SaveChanges();
        }

        public int Update(TEntity TEntity)
        {
            _TEntitys.Update(TEntity);
            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            var dept = _TEntitys.Find(id);
            if (dept != null)
            {
                _TEntitys.Remove(dept);
                return context.SaveChanges();
            }
            return 0;
        }
    }
}
