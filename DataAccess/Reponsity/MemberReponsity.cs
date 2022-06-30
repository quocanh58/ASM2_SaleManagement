using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace DataAccess.Reponsity
{
    public class MemberReponsity : IMemberReponsity
    {
        void IMemberReponsity.Add(Member member) => MemberDAO.Instance.Insert(member);

        void IMemberReponsity.Detele(Member member) => MemberDAO.Instance.Delete(member);

        IEnumerable<Member> IMemberReponsity.GetAllMember() => MemberDAO.Instance.GetAllMember();

        void IMemberReponsity.Update(Member member) => MemberDAO.Instance.Update(member);
    }
}
