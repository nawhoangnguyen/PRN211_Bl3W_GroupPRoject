using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void Add(MemberDTO member)
        {
            MemberDAO.Instance.Add(member);
        }

        public void Delete(int id)
        {
            MemberDAO.Instance.Delete(id);

        }

        public List<MemberDTO> GetAll()
        {
            return MemberDAO.Instance.GetMembers();

        }

        public MemberDTO GetOneById(int id)
        {
            return MemberDAO.Instance.GetMemberById(id);

        }

        public MemberDTO Login(string email, string password)
        {
            return MemberDAO.Instance.Login(email, password);
        }


        public void Update(MemberDTO member)
        {
            MemberDAO.Instance.Update(member);

        }
    }
}
