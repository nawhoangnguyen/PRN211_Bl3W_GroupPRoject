using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void Add(OrderDetailDTO orderDetail)
        {
            OrderDetailDAO.Instance.Add(orderDetail);


        }



        public List<OrderDetailDTO> GetAll()
        {
            return OrderDetailDAO.Instance.GetOrders();

        }

        public List<OrderDetailDTO> GetOneById(int id)
        {
            return null;        }

        public void Update(OrderDetailDTO orderDetail)
        {
            throw new NotImplementedException();
        }

        public OrderDetailDTO FindOrderDetailByOrderId(int id)
        {
            return OrderDetailDAO.Instance.FindOrderDetailByOrderId(id);
        }
    }
}
