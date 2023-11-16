using AutoMapper.Execution;
using BusinessObject;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ShoppingSessionDAO
    {
        private static ShoppingSessionDAO instance = null;
        private static readonly object instanceLock = new object();
        private ShoppingSessionDAO() { }

        private SaleParrotMgtContext context = new SaleParrotMgtContext();
        private ObjectMapper mapper = new ObjectMapper();
        public static ShoppingSessionDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ShoppingSessionDAO();
                    }
                    return instance;

                }
            }

        }

        public ShoppingSessionDTO GetShoppingSessionByUserId(int userId)
        {
            try
            {
                ShoppingSessionDTO sDto = new ShoppingSessionDTO();
                ShoppingSession entity = context.ShoppingSessions.SingleOrDefault(s => s.MemberId == userId);
                sDto = mapper.Map(entity, sDto);
               
                return sDto;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void Add(ShoppingSessionDTO shoppingSession)
        {
            try
            {
                ShoppingSession entity = new ShoppingSession();
                entity = mapper.Map(shoppingSession, entity);
                context.ShoppingSessions.Add(entity);
                context.SaveChanges();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
