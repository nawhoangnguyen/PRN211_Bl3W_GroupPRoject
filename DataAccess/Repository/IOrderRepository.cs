using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        public List<OrderDTO> GetAll();
        public OrderDTO GetById(int id);
        public OrderDTO Add(OrderDTO order);   
        public void Update(OrderDTO order);    
        public void Delete(int id);
        public List<OrderDTO> GetOrdersByUserId(int id);
        public List<OrderDTO> FilterOrder(DateTime from, DateTime to, Int32 memberId);

    }
}
