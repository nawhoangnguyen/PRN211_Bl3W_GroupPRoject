using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class DiscountRepository : IDiscountRepository
    {
        public void Add(DiscountDTO discount)
        {
            DiscountDAO.Instance.Add(discount);
        }

        public void Update(DiscountDTO discount)
        {
            DiscountDAO.Instance.Update(discount);
        }

        public void Delete(int discount)
        {
            DiscountDAO.Instance.Delete(discount);
        }

        public List<DiscountDTO> GetAll()
        {
           return DiscountDAO.Instance.GetDiscounts();
        }

        public DiscountDTO GetDiscountDTO(int id)
        {
            return DiscountDAO.Instance.GetDiscountId(id);
        }
    }
}
