using UsersService.API.Models;

namespace UsersService.API.Manager;

public interface IUserManager
{
    Task<UserResponse> GetUserListAsync();

    Task<UserResponse> GetUserByIdAsync(int id);
}
