using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();

        private MemberDAO() { }


        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Member> GetAllMember()
        {
            FStoreManagementDBContext fptEduStoreContext = new FStoreManagementDBContext();
            var memberList = from member in fptEduStoreContext.Members select member;
            return memberList.ToList();
        }

        public IEnumerable<Member> GetMemberByEmail(string email)
        {
            FStoreManagementDBContext fptEduStoreContext = new FStoreManagementDBContext();
            var members = from member in fptEduStoreContext.Members where member.Email.Equals(email) select member;
            return members.ToList();
        }

        public void Insert(Member member)
        {
            try
            {
                using (var FStoreManagementDBContext = new FStoreManagementDBContext())
                {
                    FStoreManagementDBContext.Members.Add(member);
                    FStoreManagementDBContext.SaveChanges();
                };

            }
            catch (Exception ex)
            {

                throw new Exception("Error Add new Member" + ex.Message);
            }
        }

        public void Update(Member member)
        {
            try
            {
                using (var FStoreManagementDBContext = new FStoreManagementDBContext())
                {
                    FStoreManagementDBContext.Members.Update(member);
                    FStoreManagementDBContext.SaveChanges();
                };
            }
            catch (Exception ex)
            {

                throw new Exception("Error update Member " + ex.Message);
            }
        }

        public void Delete(Member member)
        {
            try
            {
                using (var FStoreManagementDBContext = new FStoreManagementDBContext())
                {
                    var mem = FStoreManagementDBContext.Members.SingleOrDefault(m => m.MemberId == member.MemberId);
                    FStoreManagementDBContext.Members.Remove(mem);
                    FStoreManagementDBContext.SaveChanges();
                };
            }
            catch (Exception ex)
            {

                throw new Exception("Error delete member " + ex.Message);
            }
        }

        public Member CheckLogin(string email, string password)
        {
            FStoreManagementDBContext fStoreManagementDBContext = new FStoreManagementDBContext();
            var check = (from member in fStoreManagementDBContext.Members
                         where member.Email.Equals(email) && member.Password.Equals(password)
                         select member).FirstOrDefault();
            return check;
        }
    }
}
