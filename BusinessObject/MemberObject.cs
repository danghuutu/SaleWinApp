using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class MemberObject
    {
        public MemberObject()
        {
        }
        public int MemberId { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Password { get; set; }

        public MemberObject(int memberId, string email, string companyName, string city, string country, string password)
        {
            MemberId = memberId;
            Email = email;
            CompanyName = companyName;
            City = city;
            Country = country;
            Password = password;
        }

        
    }
}
