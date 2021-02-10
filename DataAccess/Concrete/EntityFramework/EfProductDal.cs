using DataAccess.Absract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //IDisposable pattern implementation of 
            using (NortWindContext context = new NortWindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NortWindContext context = new NortWindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }

            public Product Get(Expression<Func<Product, bool>> filter)
            {
                using (NortWindContext context = new NortWindContext())
                {
                    return context.Set<Product>().SingleOrDefault(filter);
                }
            }

            public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
            {
                using (NortWindContext context=new NortWindContext())
                {
                    return filter == null 
                        ? context.Set<Product>().ToList() 
                        : context.Set<Product>().Where(filter).ToList;           }
            }

            public void Update(Product entity)
            {
                using (NortWindContext context = new NortWindContext())
                {
                    var updatedEntity = context.Entry(entity);
                    updatedEntity.State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }
    }
}
