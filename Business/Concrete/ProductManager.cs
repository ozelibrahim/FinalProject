using DataAccess.Absract;
using DataAccess.Concrete.EntityFramework;
using Entities.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;
        private ProductManager productManager;
        private EfProductDal productDal;

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public ProductManager(EfProductDal productDal)
        {
            this.productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //İş kodları
            //Yetkisi var mı?

            return _ProductDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _ProductDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max);
        }
    }
}
