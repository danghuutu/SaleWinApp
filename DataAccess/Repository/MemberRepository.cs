using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {

        public MemberObject GetMemberByEmail(string email)
        {
            MemberDAO memberDAO = new MemberDAO();
            MemberObject member = null;
            member = memberDAO.GetMemberByEmail(email);
            return member;
        }
        public List<MemberObject> GetMembers()
        {
            MemberDAO memberDAO = new MemberDAO();
            List<MemberObject> members = null;
            members = memberDAO.GetAllMembers();
            return members;
        }
        public MemberObject GetMemberById(int memberId)
        {
            MemberDAO memberDAO = new MemberDAO();
            MemberObject member = memberDAO.GetMemberById(memberId);
            return member;
        }
        public void DeleteMember(int memberId)
        {
            MemberDAO memberDAO = new MemberDAO();
            memberDAO.DeleteMemberById(memberId);

        }
        public void InsertMember(MemberObject member)
        {
            MemberDAO memberDAO = new MemberDAO();
            memberDAO.InsertNewMember(member);


        }
        public void UpdateMember(MemberObject member)
        {
            MemberDAO memberDAO = new MemberDAO();
            memberDAO.UpdateMember(member);

        }
    }
}
