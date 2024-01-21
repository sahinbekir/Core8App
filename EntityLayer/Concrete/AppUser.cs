using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        // Extra Properties For Identity User Table.
        /*
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? LastName { get; set; }
        public string? ImageUrl { get; set; }
        public string? Address { get; set; }
        public DateTime BornDate { get; set; }

        public DateTime RegisterDate { get; set; }
        public DateTime ProfileUpdatedDate { get; set; }

        public bool IsBlocked { get; set; }
        public DateTime? BlockStartDate { get; set; }
        public DateTime? BlockEndDate { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeleteStartDate { get; set; }
        public DateTime? DeleteEndDate { get; set; }
         */

        /*
        1Id
        2UserName
        3NormalizedUserName
        4Email
        5NormalizedEmail
        6EmailConfirmed
        7PasswordHash
        8SecurityStamp
        9ConcurrencyStamp
        10PhoneNumber
        11PhoneNumberConfirmed
        12TwoFactorEnabled
        13LockoutEnd
        14LockoutEnabled
        15AccessFailedCount
         */
    }
}
