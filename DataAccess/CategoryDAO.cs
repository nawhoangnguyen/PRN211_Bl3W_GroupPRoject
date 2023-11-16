using AutoMapper;
using BusinessObject;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDAO
    {
        private static CategoryDAO instance = null;
        private static readonly object instanceLock = new object();
        private CategoryDAO() { }
        public static CategoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;

                }
            }

        }
        private static SaleParrotMgtContext context = new SaleParrotMgtContext();
        private ObjectMapper mapper = new ObjectMapper();
        public List<CategoryDTO> GetCategories()
        {

            try
            {
                List<CategoryDTO> list = new List<CategoryDTO>();
                List<Category> entities = context.Categories.ToList();
                foreach (Category category in entities)
                {
                    CategoryDTO categoryDTO = mapper.Map(category, new CategoryDTO());
                    list.Add(categoryDTO);
                }
                return list;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;

            }



        }
        public CategoryDTO GetProductId(int id)
        {
            try
            {

                // Use the SingleOrDefault method to retrieve a member by ID.
                CategoryDTO category = new CategoryDTO();
                category = mapper.Map(context.Categories.SingleOrDefault(m => m.CategoryId == id), category);

                if (category != null)
                {
                    return category;
                }
                else
                {
                    throw new Exception("Category not found"); // Handle the case where no member with the given ID is found.
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }
    }

  
}
