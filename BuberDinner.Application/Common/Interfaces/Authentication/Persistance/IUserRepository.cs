using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Common.Interfaces.Authentication.Persistance
{
    public interface IUserRepository
    {
        User? GetUserByEmailAsync(string email);
        void Add(User user);

    }
}