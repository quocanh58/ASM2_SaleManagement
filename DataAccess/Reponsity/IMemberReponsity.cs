using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace DataAccess.Reponsity
{
    public interface IMemberReponsity
    {
        IEnumerable<Member> GetAllMember();
        public void Add(Member member);
        public void Detele(Member member);
        public void Update(Member member);

    }
}
