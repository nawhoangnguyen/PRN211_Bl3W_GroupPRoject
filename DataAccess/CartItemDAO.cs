using BusinessObject;
using BusinessObject.Models;

namespace DataAccess
{
    public class CartItemDAO
    {
        private static CartItemDAO instance = null;
        private static readonly object instanceLock = new object();
        private CartItemDAO() { }

        private SaleParrotMgtContext context = new SaleParrotMgtContext();
        private ObjectMapper mapper = new ObjectMapper();
        public static CartItemDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CartItemDAO();
                    }
                    return instance;

                }
            }

        }
        public void Add(CartItemDTO member)
        {
            try
            {
                CartItem entity = new CartItem();
                entity = mapper.Map(member, entity);
                context.CartItems.Add(entity);
                context.SaveChanges();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public List<CartItemDTO> GetAllCartItemsByShoppingId(int shoppingId)
        {
            try
            {
                List<CartItemDTO> list = new List<CartItemDTO>();
                List<CartItem> entities = context.CartItems.Where(c => c.ShoppingSessionId == shoppingId).ToList();
                foreach (var entity in entities)
                {
                    CartItemDTO c = mapper.Map(entity, new CartItemDTO());
                    list.Add(c);

                }
                return list;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
    }
}
