using System;
using System.Collections.Generic;
using System.Linq;
using Passenger.Core.Models;
using Passenger.Core.Repositories;

namespace Passenger.Infrastructure.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        private static ISet<User> Users = new HashSet<User>();

        static InMemoryUserRepository()
        {
            Users.Add(new User("asd@mail.com", "pass", "salt"));
        }

        public void Add(User user) => Users.Add(user);

        public User Get(Guid id) => Users.Single(u => u.Id == id);

        public User Get(string email) => Users.Single(u => u.Email == email.ToLowerInvariant());

        public IEnumerable<User> Get() => Users;

        public void Remove(User user) => Users.Remove(user);

        public void Update(User user) 
        {
        }
    }
}