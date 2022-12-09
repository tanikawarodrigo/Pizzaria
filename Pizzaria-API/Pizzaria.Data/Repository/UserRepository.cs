using Dapper;
using Microsoft.EntityFrameworkCore;
using Pizzaria.Data.IRepository;
using Pizzaria.Domain.DTO;
using Pizzaria.Domain.Model;
using Pizzaria.Infraestructure.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DapperConnection _dapperConnection;
        private const string GetUserByCpfDapper = @"SELECT * FROM [Users] WHERE Cpf = @Cpf";

        public UserRepository(ApplicationDbContext context, DapperConnection dapperConnection)
        {
            _context = context;
            _dapperConnection = dapperConnection;
        }

        public async Task<List<User>> GetAllUser(int skip, int take)
        {
            var users = await _context.Users.Skip(skip).Take(take).ToListAsync();
            return users;
        }

        public async Task<User> GetUserByCpf(string cpf)
        {
            var user = await _dapperConnection.Connection.QueryFirstOrDefaultAsync<User>(GetUserByCpfDapper, new { cpf });
            return user;
        }

        public async Task<bool> SaveChanges()
        {
            return await _context.SaveChangesAsync()>0;
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
        }

        public async void UserRegisterAsync(UserDTO userRegisterRequest)
        {
            User user = new()
            {
                Nome = userRegisterRequest.Nome,
                Cpf = userRegisterRequest.Cpf,
                Celular = userRegisterRequest.Celular,
                Endereço = userRegisterRequest.Endereço,
                Role = userRegisterRequest.Role,
            };
            await _context.AddAsync(user);

        }

        public void DeleteUser(User user)
        {
            _context.Users.Remove(user);
        }
    }
}
