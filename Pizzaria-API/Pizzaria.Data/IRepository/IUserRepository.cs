using Pizzaria.Domain.DTO;
using Pizzaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Data.IRepository
{
    public interface IUserRepository
    {
        Task<User> GetUserByCpf(string cpf);
        Task<List<User>> GetAllUser(int skip, int take);
        void UpdateUser(User user);
        void DeleteUser(User user);
        void UserRegisterAsync(UserDTO user);
        Task<bool> SaveChanges();

    }
}
