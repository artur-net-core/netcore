using System;
using System.Collections.Generic;
using Passenger.Core.Models;

namespace Passenger.Core.Repositories
{
    public interface IUserRepository
    {
         User Get(Guid id);
         User Get(string email);
         IEnumerable<User> Get();
         void Add(User user);
         void Update(User user);
         void Remove(User user);
    }
}