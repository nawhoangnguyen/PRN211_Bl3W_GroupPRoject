using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        public List<ProductDTO> GetAll();
        public void Add(ProductDTO product);
        public void Update(ProductDTO product);    
        public void Delete(int id);    
        public ProductDTO GetOneById(int id);
        public List<ProductDTO> SearchByNameAndIdOrSortByUnitPriceAndUnitsPriceInStock(string NameOrId, string from, string to, bool check);
    }

}
