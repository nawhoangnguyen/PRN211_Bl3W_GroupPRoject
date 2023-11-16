using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public List<MemberDTO> GetAll();
        public void Add(MemberDTO member);
        public void Delete(int id);
        public void Update(MemberDTO member);  
        public MemberDTO GetOneById(int id);
        public MemberDTO Login(string email, string password);
    }
}
