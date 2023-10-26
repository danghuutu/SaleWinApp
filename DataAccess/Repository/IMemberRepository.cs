using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public MemberObject GetMemberByEmail(string email);
        public List<MemberObject> GetMembers();
        public MemberObject GetMemberById(int memberId);
        public void DeleteMember(int memberId);
        public void InsertMember(MemberObject member);
        public void UpdateMember(MemberObject member);
        

    }
}
