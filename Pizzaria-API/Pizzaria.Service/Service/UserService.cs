using AutoMapper;
using Pizzaria.Data.IRepository;
using Pizzaria.Domain.DTO;
using Pizzaria.Domain.Model;
using Pizzaria.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Service.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<bool> CreateUser(UserDTO userDTO)
        {
            var result = await _userRepository.GetUserByCpf(userDTO.Cpf);
            if(result == null)
            {

            }
            throw new Exception();
        }

        public async Task<bool> DeleteUser(UserDTO userDTO)
        {
            var userExist = await _userRepository.GetUserByCpf(userDTO.Cpf);
            if(userExist == null)
            {
                throw new Exception();
            }
            _userRepository.DeleteUser(userExist);
            var result = await _userRepository.SaveChanges();
            if(result == false)
            {
                throw new Exception();
            }
            return result;
        }

        public async Task<List<User>> GetAllUser(int skip, int take)
        {
            var users = await _userRepository.GetAllUser(skip, take);
            return users;
        }

        public async Task<User> GetUserByCpf(string cpf)
        {
            var user = await _userRepository.GetUserByCpf(cpf);
            if(user == null)
            {
                throw new Exception();
            }
            return user;
        }
    }
}
