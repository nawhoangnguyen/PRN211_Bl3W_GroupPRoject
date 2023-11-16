using BusinessObject.Models;

namespace DataAccess.Repository
{
    public interface IPostRepository
    {
        public List<PostDTO> GetAll();
        public PostDTO GetOneById(int id);
        public void Add(PostDTO postDTO);
        public void Updated(PostDTO postDTO);
        public void Delete(int id);
        public List<PostDTO> SearchByTileAndSortByDate(string title, string sortDate);


    }
}
