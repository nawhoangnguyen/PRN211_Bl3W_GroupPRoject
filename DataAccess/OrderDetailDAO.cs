using BusinessObject;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class OrderDetailDAO
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();

        private OrderDetailDAO() { }
        private SaleParrotMgtContext context = new SaleParrotMgtContext();
        private ObjectMapper mapper = new ObjectMapper();
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }


        public List<OrderDetailDTO> GetOrders()
        {

            try
            {
              

                    return mapper.Map(context.OrderDetails.ToList(), new List<OrderDetailDTO>());
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }



        }
       
        public void Add(OrderDetailDTO orderDetail)
        {
            try
            {

                OrderDetail entity = new OrderDetail();
                    entity = mapper.Map(orderDetail, entity);
                    context.OrderDetails.Add(entity);
                    
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public OrderDetailDTO FindOrderDetailByOrderId(int id)
        {

            OrderDetailDTO orderDetail = new OrderDetailDTO();
            orderDetail = mapper.Map(context.OrderDetails.SingleOrDefault(o => o.OrderId == id), orderDetail);
            return orderDetail;
        }


    }
}
