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
    public class OrderDAO
    {
        private static OrderDAO instance;
        private static readonly object instanceLock = new object();

        private OrderDAO() { }

        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        private SaleParrotMgtContext context = new SaleParrotMgtContext();
        private ObjectMapper mapper = new ObjectMapper();

        public List<OrderDTO> GetOrders()
        {
            try
            {
                List<OrderDTO> list = new List<OrderDTO>();
                List<Order> orders = context.Orders.ToList();
                foreach (var order in orders)
                {
                    OrderDTO dto = mapper.Map(order, new OrderDTO());
                    list.Add(dto);
                }
                return list;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public OrderDTO GetOrderId(int id)
        {
            try
            {

                // Use the SingleOrDefault method to retrieve a member by ID.
                OrderDTO order = new OrderDTO();
                Order entity = context.Orders.SingleOrDefault(m => m.OrderId == id);

                if (order != null)
                {
                    order = mapper.Map(entity, order);

                    return order;
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

        public OrderDTO Add(OrderDTO order)
        {
            try
            {
                Order entity = new Order();
                entity = mapper.Map(order, entity);
                context.Orders.Add(entity);
                context.SaveChanges();
                order = mapper.Map(entity, order);  

                return order;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        public void Update(OrderDTO order)
        {
            try
            {
                Order entity = new Order();
                entity = mapper.Map(order, entity);

                // Attach the member to the context so that Entity Framework tracks the changes
                context.Orders.Attach(entity);

                // Mark the member as modified, so Entity Framework knows to update it
                var entry = context.Entry(entity);
                entry.State = EntityState.Modified;

                // Save the changes to the database
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
                Order order = context.Orders.SingleOrDefault(m => m.OrderId == id);

                if (order != null)
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Order not found"); // Handle the case where no member with the given ID is found.
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<OrderDTO> SearchAndSort(DateTime from, DateTime to, Int32 memberId)
        {
          

            if (memberId > 0)
            {
                List<OrderDTO> list = new List<OrderDTO>();
                List<Order> orders = context.Orders.Where(m => m.OrderDate >= from
                && m.OrderDate <= to && m.MemberId == memberId).OrderByDescending(m => m.OrderId).ToList();
                foreach (var order in orders)
                {
                    OrderDTO dto = mapper.Map(order, new OrderDTO());
                    list.Add(dto);
                }
                return list;
            }
                
            else {
                List<OrderDTO> list = new List<OrderDTO>();
                List<Order> orders = context.Orders.Where(m => m.OrderDate >= from && m.OrderDate <= to)
                    .OrderByDescending(m => m.OrderId).ToList();
                foreach (var order in orders)
                {
                    OrderDTO dto = mapper.Map(order, new OrderDTO());
                    list.Add(dto);
                }
                return list;
            }


        }

        public List<OrderDTO> GetOrdersByUserId(int id)
        {
            List<OrderDTO> list = new List<OrderDTO>();
            List<Order> orders = context.Orders.Where(m => m.MemberId == id)
                    .OrderByDescending(m => m.OrderId).ToList();
            foreach (var order in orders)
            {
                OrderDTO dto = mapper.Map(order, new OrderDTO());
                list.Add(dto);
            }
            return list;

           


            
        }



    }
}
