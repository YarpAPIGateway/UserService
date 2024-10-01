using UsersService.API.Infrastructure.Data;
using UsersService.API.Models;

namespace UsersService.API.Manager;

public class UserManager : IUserManager
{
    public async Task<UserResponse> GetUserByIdAsync(int id)
    {
        UserDataTable userDataTable = new UserDataTable();
        var response = await userDataTable.UserList();
        var result = response.FirstOrDefault(x => x.Id == id);
        return new UserResponse()
        {
            Success = true,
            Message = "Data Received",
            SingleData = result
        };
    }

    public async Task<UserResponse> GetUserListAsync()
    {
        UserDataTable userDataTable = new UserDataTable();
        var result = await userDataTable.UserList();
        return new UserResponse()
        {
            Success = true,
            Message = "Data Received",
            Data = result
        };
    }
}
