using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sklad2.Core.DTO;
using Sklad2.Core.IReposytories;
using Sklad2.Core;
using Microsoft.EntityFrameworkCore;


namespace Sklad2.DAL
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _datacontext;

        public UserRepository(DataContext datacontext)
        {
            _datacontext = datacontext;
        }

        public List<UserDto> GetAll()
        {
            var users = _datacontext.User
                .Include(u => u.Role)
                .Select(u => new UserDto
                {
                    Id = u.Id,
                    Login = u.Login,
                    Password = u.Password,
                    RoleId = u.RoleId,
                    Role = new UserRoleDto
                    {
                        Id = u.Role.Id,
                        Name = u.Role.Name
                    }
                })
                .ToList();
            return users;
        }
    }
}
