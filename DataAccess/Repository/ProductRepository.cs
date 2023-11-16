using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void Add(ProductDTO product)
        {
            ProductDAO.Instance.Add(product);
        }

        public void Delete(int id)
        {
            ProductDAO.Instance.Delete(id);

        }

        public List<ProductDTO> GetAll()
        {
            return ProductDAO.Instance.GetProducts();

        }

        public ProductDTO GetOneById(int id)
        {
            return ProductDAO.Instance.GetProductId(id);
        }

        public List<ProductDTO> SearchByNameAndIdOrSortByUnitPriceAndUnitsPriceInStock(string NameOrId, string from, string to, bool check)
        {
            return ProductDAO.Instance.SearchAndSort(NameOrId, from, to, check);
        }

        public void Update(ProductDTO product)
        {
            ProductDAO.Instance.Update(product);

        }
    }
}
