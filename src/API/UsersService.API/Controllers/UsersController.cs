using Microsoft.AspNetCore.Mvc;
using UsersService.API.Manager;

namespace UsersService.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserManager userManager;

    public UsersController(IUserManager _userManager) => userManager = _userManager;

    [HttpGet]
    public async Task<IActionResult> GetUsersAsync()
    {
        var result = await userManager.GetUserListAsync();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserByIdAsync([FromRoute] int id)
    {
        var result = await userManager.GetUserByIdAsync(id);
        return Ok(result);
    }
}
