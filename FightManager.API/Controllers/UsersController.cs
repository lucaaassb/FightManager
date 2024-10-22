using Microsoft.AspNetCore.Mvc;
using FightManager.Application.Models;
using FightManager.Core.Entities;
using FightManager.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace FightManager.API.Controllers;
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly FightManagerDbContext _context;

        public UsersController(FightManagerDbContext context)
        {
            _context = context;
        }
        
        // POST api/users
        [HttpPost("student")]
        public IActionResult Post(CreateUserInputModel model)
        {
            var user = new User(model.Fullname, model.Email, model.Role, model.CreatedAt);
            
            _context.Users.Add(user);
            _context.SaveChanges();
            
            return NoContent();
        }

        [HttpPost("instructor")]
        public IActionResult Post(CreateUserInputModel model)
        {
            var user = new User(model.Fullname, model.Email, model.Role, model.CreatedAt);
            
            _context.Users.Add(user);
            _context.SaveChanges();
            
            return NoContent();
        }
    }
}

