using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IDiscountRepository
    {
        public void Add(DiscountDTO discount);
        public void Update(DiscountDTO discount);
        public void Delete(int discount);
        public List<DiscountDTO> GetAll();
        public DiscountDTO GetDiscountDTO(int id);
    }
}
