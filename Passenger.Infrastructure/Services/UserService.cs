using System;
using Passenger.Core.Models;
using Passenger.Core.Repositories;
using Passenger.Infrastructure.Dto;

namespace Passenger.Infrastructure.Services
 {
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService (IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        public UserDto Get(string email)
        {
            var user = _userRepository.Get(email);

            return new UserDto
            {
                Id = user.Id,
                Email = user.Email
            };
        }

        public void Register(string email, string password)
        {
            var user = _userRepository.Get(email);

            if (user != null)
            {
                throw new Exception($"User with email {email} already exists");
            }

            var salt = Guid.NewGuid().ToString("h");
            user = new User(email, password, salt);

            _userRepository.Add(user);
        }
    }
}