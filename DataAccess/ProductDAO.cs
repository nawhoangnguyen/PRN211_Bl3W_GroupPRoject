﻿using BusinessObject;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();

        private ProductDAO() { }

        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        private SaleParrotMgtContext context = new SaleParrotMgtContext();
        private ObjectMapper mapper = new ObjectMapper();
        public List<ProductDTO> GetProducts()
        {

            try
            {
                List<ProductDTO> list = new List<ProductDTO>();
                List<Product> entities = context.Products.ToList();
                foreach (Product product in entities)
                {
                    ProductDTO productDTO = mapper.Map(product, new ProductDTO());
                    list.Add(productDTO);
                }
                return list;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;

            }



        }
        public ProductDTO GetProductId(int id)
        {
            try
            {

                // Use the SingleOrDefault method to retrieve a member by ID.
                ProductDTO product = new ProductDTO();
                product = mapper.Map(context.Products.SingleOrDefault(m => m.ProductId == id), product);

                if (product != null)
                {
                    return product;
                }
                else
                {
                    throw new Exception("Product not found"); // Handle the case where no member with the given ID is found.
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }
        public void Add(ProductDTO product)
        {
            try
            {

                Product entity = new Product();
                entity = mapper.Map(product, entity);
                context.Products.Add(entity);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void Update(ProductDTO product)
        {
            try
            {
                Product entity = new Product();
                entity = mapper.Map(product, entity);

                context.Products.Attach(entity);

                var entry = context.Entry(entity);
                entry.State = EntityState.Modified;

                context.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {

                // Use the SingleOrDefault method to retrieve a member by ID.
                Product product = context.Products.SingleOrDefault(m => m.ProductId == id);

                if (product != null)
                {
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product not found"); // Handle the case where no member with the given ID is found.
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        public List<ProductDTO> SearchAndSort(string nameOrId, string from, string to, bool check)
        {

            var query = context.Products.AsQueryable();

            if (check)
            {

                if (!string.IsNullOrEmpty(nameOrId))
                {
                    query = query.Where(p => p.ProductName.Contains(nameOrId));
                }

                if (!string.IsNullOrEmpty(from))
                {
                    if (Decimal.Parse(from) > 0)
                    {
                        query = query.Where(p => p.UnitPrice >= Decimal.Parse(from));

                    }

                }

                if (!string.IsNullOrEmpty(to))
                {
                    if (Decimal.Parse(to) > 0)
                    {
                        query = query.Where(p => p.UnitPrice <= Decimal.Parse(to));

                    }

                }


            }
            else
            {

                if (!string.IsNullOrEmpty(nameOrId))
                {
                    query = query.Where(p => p.ProductId == Int32.Parse(nameOrId));
                }

                if (!string.IsNullOrEmpty(from))
                {
                    if (Int32.Parse(from) > 0)
                    {
                        query = query.Where(p => p.UnitsInStock >= Int32.Parse(from));

                    }

                }

                if (!string.IsNullOrEmpty(to))
                {
                    if (Int32.Parse(to) > 0)
                    {
                        query = query.Where(p => p.UnitsInStock <= Int32.Parse(to));

                    }

                }

            }
            List<ProductDTO> list = new List<ProductDTO>();
            List<Product> entities = query.ToList();
            foreach (Product product in entities)
            {
                ProductDTO productDTO = mapper.Map(product, new ProductDTO());
                list.Add(productDTO);
            }
            return list;

        }
    }
}