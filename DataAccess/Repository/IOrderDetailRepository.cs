using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        public List<OrderDetailDTO> GetAll();
        public void Add(OrderDetailDTO orderDetail);
        public List<OrderDetailDTO> GetOneById(int id);
        public OrderDetailDTO FindOrderDetailByOrderId(int id);

    }
}
