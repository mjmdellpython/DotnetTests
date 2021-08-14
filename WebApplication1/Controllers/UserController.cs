using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Entity;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("WebApplication1/[controller]")]
    public class UserController: ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUses()
        {
            return await _context.Users.ToListAsync();
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUses(int id)
        {
            return await _context.Users.FindAsync(id);

        }
    }
}