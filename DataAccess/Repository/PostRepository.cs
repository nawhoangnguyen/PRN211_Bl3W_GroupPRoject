using BusinessObject.Models;

namespace DataAccess.Repository
{
    public class PostRepository : IPostRepository
    {

        public void Add(PostDTO postDTO)
        {
            PostDAO.Instance.Add(postDTO);
        }


        public void Delete(int id)
        {
            PostDAO.Instance.Delete(id);
        }

        public List<PostDTO> GetAll()
        {
            return PostDAO.Instance.GetPosts();
        }

        public PostDTO GetOneById(int id)
        {
            return PostDAO.Instance.GetPostId(id);
        }

        public List<PostDTO> SearchByTileAndSortByDate(string title, string sortDate)
        {

            return PostDAO.Instance.SearchAndSort(title, sortDate);
        }

        public void Updated(PostDTO postDTO)
        {
            PostDAO.Instance.Update(postDTO);
        }
    }
}
