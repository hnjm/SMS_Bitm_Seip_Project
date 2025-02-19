﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using StockManagementSystem.Repository;

namespace StockManagementSystem.Bill
{
    class ProductManager
    {
        ProductRepository _productRepository=new ProductRepository();

        public bool DeleteProduct(Product _product)
        {
            return _productRepository.DeleteProduct(_product);
        }

        public bool UpdateProduct(Product _product)
        {
            return _productRepository.UpdateProduct(_product);
        }
        public List<Product> ShowProduct(Product _product)
        {
            return _productRepository.ShowProduct(_product);
        }

        public List<Category> ComboBoxCategoryList()
        {
            return _productRepository.ComboBoxCategoryList();
        }

        public List<Product> SearchProductCode(Product _product)
        {
            return _productRepository.SearchProductCode(_product);
        }
        public List<Product> SearchProductCode2(Product _product)
        {
            return _productRepository.SearchProductCode2(_product);
        }

        public List<Product> SearchProductName(Product _product)
        {
            return _productRepository.SearchProductName(_product);
        }

        public bool SaveProduct(Product _product)
        {
            return _productRepository.SaveProduct(_product);
        }

        public List<Product> SearchProductCatagory(Product _product)
        {
            return _productRepository.SearchProductCatagory(_product);
        }
        public List<Product> SearchProductName2(Product _product)
        {
            return _productRepository.SearchProductName2(_product);
        }
    }
}
