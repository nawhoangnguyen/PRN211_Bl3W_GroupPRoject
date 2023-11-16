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
    public class DiscountDAO
    {
        private static DiscountDAO instance = null;
        private static readonly object instanceLock = new object();

        private DiscountDAO() { }
        private SaleParrotMgtContext context = new SaleParrotMgtContext();
        private ObjectMapper mapper = new ObjectMapper();
        public static DiscountDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new DiscountDAO();
                    }
                    return instance;
                }
            }
        }

        public List<DiscountDTO> GetDiscounts()
        {
            try
            {
                List<DiscountDTO> list = new List<DiscountDTO>();
                List<Discount> discounts = context.Discounts.ToList();
                foreach (Discount discount in discounts)
                {
                    DiscountDTO discountDTO = mapper.Map(discount, new DiscountDTO());
                    list.Add(discountDTO);
                }
                return list;

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

        public DiscountDTO GetDiscountId(int id)
        {
            try
            {
                DiscountDTO discount = new DiscountDTO();
                discount = mapper.Map(context.Discounts.SingleOrDefault(m => m.DiscountId == id), discount);
                if (discount != null)
                {
                    return discount;
                }
                else
                {
                    throw new Exception("Discount not found"); // Handle the case where no member with the given ID is found.
                }

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void Delete(int id)
        {
            try
            {

                // Use the SingleOrDefault method to retrieve a member by ID.
                Discount discount = context.Discounts.SingleOrDefault(m => m.DiscountId == id);

                if (discount != null)
                {
                    context.Discounts.Remove(discount);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Discount not found"); // Handle the case where no member with the given ID is found.
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public void Update(DiscountDTO discount)
        {
           

            try
            {
                // Replace with the actual ID of the post you want to update

                // Retrieve the Post entity from the database
                Discount DiscountToUpdate = context.Discounts.Find(discount.DiscountId);

                if (DiscountToUpdate != null)
                {
                    // Update the PostTitle property
                    DiscountToUpdate.DiscountName = discount.DiscountName;
                    DiscountToUpdate.DiscountPercent = discount.DiscountPercent;
                    DiscountToUpdate.Description = discount.Description;

                    // Save Changes to persist the update
                    context.SaveChanges();
                }

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Add(DiscountDTO discount)
        {
            try
            {

                Discount entity = new Discount();
                entity = mapper.Map(discount, entity);
                context.Discounts.Add(entity);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
