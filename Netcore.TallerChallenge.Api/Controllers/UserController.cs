using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Netcore.TallerChallenge.Api.Infrastructure;

namespace Netcore.TallerChallenge.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("username")]
        public async Task<IActionResult> GetNameAsync([FromQuery]string username)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x =>
                x.Username.ToLowerInvariant() == username.ToLowerInvariant());
            
            return Ok(user.Name);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var users = _context.Users;

            return Ok(users);
        }
    }
}
