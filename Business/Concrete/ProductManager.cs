﻿using Business.Abstract;
using DataAccsess.Abstract;
using DataAccsess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager()
        {
        }

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {

            //İş kodları
            //Yetki kontrol
            return _productDal.GetAll();
            
        }
    }
}
