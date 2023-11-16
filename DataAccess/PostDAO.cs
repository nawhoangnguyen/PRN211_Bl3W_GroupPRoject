using BusinessObject;
using BusinessObject.Models;

namespace DataAccess
{
    public class PostDAO
    {
        private static PostDAO instance = null;
        private static readonly object instanceLock = new object();

        private PostDAO() { }
        private SaleParrotMgtContext context = new SaleParrotMgtContext();
        private ObjectMapper mapper = new ObjectMapper();
        public static PostDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new PostDAO();
                    }
                    return instance;
                }
            }
        }
        public List<PostDTO> GetPosts()
        {

            try
            {
                List<PostDTO> list = new List<PostDTO>();
                List<Post> posts = context.Posts.OrderByDescending(p => p.PostId).ToList();
                foreach (var post in posts)
                {
                    PostDTO dto = mapper.Map(post, new PostDTO());
                    list.Add(dto);
                }

                return list.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;

            }



        }

        public PostDTO GetPostId(int id)
        {
            try
            {

                // Use the SingleOrDefault method to retrieve a member by ID.
                PostDTO post = new PostDTO();
                post = mapper.Map(context.Posts.SingleOrDefault(m => m.PostId == id), post);

                if (post != null)
                {
                    return post;
                }
                else
                {
                    throw new Exception("Post not found"); // Handle the case where no member with the given ID is found.
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }
        public void Add(PostDTO post)
        {
            try
            {

                Post entity = new Post();
                entity = mapper.Map(post, entity);
                context.Posts.Add(entity);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void Update(PostDTO post)
        {
            try
            {
                // Replace with the actual ID of the post you want to update

                // Retrieve the Post entity from the database
                Post postToUpdate = context.Posts.Find(post.PostId);

                if (postToUpdate != null)
                {
                    // Update the PostTitle property
                    postToUpdate.PostTitle = post.PostTitle;
                    postToUpdate.PostContent = post.PostContent;


                    // Save Changes to persist the update
                    context.SaveChanges();
                }

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
                Post post = context.Posts.SingleOrDefault(m => m.PostId == id);

                if (post != null)
                {
                    context.Posts.Remove(post);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product not found"); // Handle the case where no member with the given ID is found.
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        public List<PostDTO> SearchAndSort(string title, string sortDate)
        {
            /* try
             {
 */

            var query = context.Posts.AsQueryable();



            if (!string.IsNullOrEmpty(title))
            {
                query = query.Where(p => p.PostTitle.Contains(title));
            }
            if (!string.IsNullOrEmpty(sortDate))
            {

                if (sortDate == "DESC")
                {
                    query = query.OrderByDescending(p => p.PostId);
                }
                else if (sortDate == "ASC")
                {
                    query = query.OrderBy(p => p.PostId);
                }


            }

            List<PostDTO> list = new List<PostDTO>();
            List<Post> posts = new List<Post>();


            if (string.IsNullOrEmpty(title) && string.IsNullOrEmpty(sortDate))
            {

                posts = context.Posts.OrderByDescending(p => p.PostId).ToList();


            }
            else
            {
                posts = query.ToList();
            }

            foreach (var post in posts)
            {
                PostDTO dto = mapper.Map(post, new PostDTO());
                list.Add(dto);
            }
            return list;




            /*   }  catch (Exception ex)
               {
                   Console.WriteLine(ex.Message);
                   return null;

               }*/

        }

    }






}
