using BusinessObject;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get {
                lock (instanceLock) {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;

                }
            }

        }
        private static SaleParrotMgtContext context = new SaleParrotMgtContext();
        private ObjectMapper mapper = new ObjectMapper();
        public List<MemberDTO> GetMembers()
        {
            try
            {
                List<MemberDTO> list = new List<MemberDTO>();
                List<Member> members = context.Members.ToList();
                foreach (var member in members)
                {
                    MemberDTO dto = mapper.Map(member, new MemberDTO());
                    list.Add(dto);
                }
                    return list;
                
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

  

        public MemberDTO GetMemberById(int id)
        {
            try
            {
                Member entity = context.Members.SingleOrDefault(m => m.MemberId == id);
                MemberDTO member = new MemberDTO();
                  member = mapper.Map(entity, member) ;
                    if (member != null) return member;
                    else throw new Exception("Member not found");
                
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);

                return null;

            }
        }

        public void Add(MemberDTO member)
        {
            try
            {
                Member entity = new Member();
                entity = mapper.Map(member, entity);
                    context.Members.Add(entity);
                    context.SaveChanges();
                

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public void Update(MemberDTO memberDto)
        {
            try
            {
                // Thay thế bằng ID thực tế của Member bạn muốn cập nhật
                Member memberToUpdate = context.Members.Find(memberDto.MemberId);

                if (memberToUpdate != null)
                {
                    // Cập nhật các thuộc tính
                    memberToUpdate.Email = memberDto.Email;
                    memberToUpdate.CompanyName = memberDto.CompanyName;
                    memberToUpdate.City = memberDto.City;
                    memberToUpdate.Country = memberDto.Country;
                    memberToUpdate.Password = memberDto.Password;
                    // ... thêm bất kỳ thuộc tính cập nhật nào khác tại đây

                    // Lưu thay đổi để duy trì cập nhật
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        public void Delete(int id) { 
            try
            {
              
                    Member member = context.Members.SingleOrDefault(m => m.MemberId == id);
                    if(member != null)
                    {
                        context.Members.Remove(member);
                        context.SaveChanges();
                    } else
                    {
                        throw new Exception("Member not found");
                    }
                 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public MemberDTO Login(string email, string password)
        {
            try
            {

                MemberDTO member = new MemberDTO();
                return mapper.Map(context.Members.SingleOrDefault(m => m.Email == email && m.Password == password), member);
                

            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public List<MemberDTO> GetAllByEmail(string email)
        {
            try
            {
                // Retrieve all members with the given email
                List<Member> members = context.Members.Where(m => m.Email.ToLower().Contains(email)).ToList();

                List<MemberDTO> memberDTOs = new List<MemberDTO>();
                foreach (var member in members)
                {
                    MemberDTO dto = mapper.Map(member, new MemberDTO());
                    memberDTOs.Add(dto);
                }

                return memberDTOs;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<MemberDTO>(); // Return an empty list in case of an exception
            }
        }

        public List<MemberDTO> GetAllByCity(string city)
        {
            try
            {
                // Retrieve all members whose city matches the specified city
                List<Member> members = context.Members.Where(m => m.City.ToLower().Contains(city.ToLower())).ToList();

                List<MemberDTO> memberDTOs = new List<MemberDTO>();
                foreach (var member in members)
                {
                    MemberDTO dto = mapper.Map(member, new MemberDTO());
                    memberDTOs.Add(dto);
                }

                return memberDTOs;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<MemberDTO>(); // Return an empty list in case of an exception
            }
        }





    }




}
