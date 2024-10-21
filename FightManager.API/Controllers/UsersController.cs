using FightManager.Application.Models;
using FightManager.Core.Entities;
using FightManager.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FightManager.API.Controllers
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

        // [HttpGet("{id")]
        // public IActionResult GetById(int id)
        // {
        //     var user = _context.Users
        //         
        // }
        
        [HttpPut("{id}/profile-picture")]
        public IActionResult PostProfilePicture(int id, IFormFile file)
        {
            var description = $"File: {file.FileName}, Size: {file.Length}";

            //Processar a imagem

            return Ok(description);
        
    }
}