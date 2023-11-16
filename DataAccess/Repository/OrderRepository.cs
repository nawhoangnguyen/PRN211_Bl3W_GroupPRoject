using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
   public class OrderRepository : IOrderRepository
    {
        public OrderDTO Add(OrderDTO order)
        {
            return OrderDAO.Instance.Add(order);

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderDTO> GetAll()
        {
            return OrderDAO.Instance.GetOrders();
        }

        public OrderDTO GetById(int id)
        {
            return OrderDAO.Instance.GetOrderId(id);
        }

        public List<OrderDTO> GetOrdersByUserId(int id)
        {
            return OrderDAO.Instance.GetOrdersByUserId(id);
        }

        public void Update(OrderDTO order)
        {
            OrderDAO.Instance.Update(order);
        }

        public List<OrderDTO> FilterOrder(DateTime from, DateTime to, Int32 memberId)
        {
            return OrderDAO.Instance.SearchAndSort(from, to, memberId);
        }

    }
}
