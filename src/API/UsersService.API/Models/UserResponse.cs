using System.Text.Json.Serialization;
using UsersService.API.Infrastructure.Data;

namespace UsersService.API.Models;

public class UserResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public List<User> Data { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public User SingleData { get; set; }
}
