using Pizzaria.Domain.DTO;
using Pizzaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Service.IService
{
    public interface IUserService
    {
        Task<bool> CreateUser(UserDTO userDTO);
        //Task<bool> UpdateUser(UserDTO userDTO);
        Task <bool> DeleteUser(UserDTO userDTO);
        //Task<User> GetUserById(int id);
        Task<List<User>> GetAllUser(int skip, int take);
        Task<User> GetUserByCpf(string cpf);
    }
}
