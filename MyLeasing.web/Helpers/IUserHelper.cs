using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MyLeasing.web.Data.Entities;

namespace MyLeasing.web.Helpers
{
    public interface IUserHelper
    {
        //en una interface solo se listan los metodos en la implementacion es donde
        // se crean los metodos que aqui se listan.
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);
    }

}
