using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsersRoom.Models
{
    public class UserInformation
    {
        public string Id { get; set; }
        public DateTime DateRegistration { get; set; }
        public string Name { get; set; }
        public DateTime LastLogin { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy H:mm:ss}", ApplyFormatInEditMode = true)]
        public string Email { get; set; }
        public string Password { get; set; }
       
    }
}
