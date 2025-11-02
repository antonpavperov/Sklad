using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad2.Core.DTO
{
    public class UserDto
    {
        public int Id { get; set; }


        public int? RoleId { get; set; }


        public UserRoleDto? Role { get; set; }


        public string? Login { get; set; }


        public string? Password { get; set; }


        
    }
}
