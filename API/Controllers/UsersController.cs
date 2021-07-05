using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class UsersController : ControllerBase
	{
		public DataContext context { get; }
		public UsersController(DataContext context)
		{
			this.context = context;
		}

		// Endpoint to get all users in db
		[HttpGet]
		public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
		{
			return await this.context.Users.ToListAsync();
		}

		// Endpoint to get specific user in db
		// api/users/3, for an example
		[HttpGet("{id}")]
		public async Task<ActionResult<AppUser>> GetUser(int id)
		{
			return await this.context.Users.FindAsync(id);
		}
	}
}