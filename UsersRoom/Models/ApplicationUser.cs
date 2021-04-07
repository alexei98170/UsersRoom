using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace UsersRoom.Models
{

    public class ApplicationUser : IdentityUser
    {
        public bool IsBlocked { get; set; }
    }
}
