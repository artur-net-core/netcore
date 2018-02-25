using Passenger.Infrastructure.Dto;

namespace Passenger.Infrastructure.Services
{
    public interface IUserService
    {
         UserDto Get(string email);
         void Register(string email, string password);
    }
}