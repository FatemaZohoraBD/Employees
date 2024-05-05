
using Employees.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Employees.Controllers
{
    [Authorize]
    public class UsersController1 : Controller
    {
        private readonly UserManager<IdentityUser>  _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ApplicationDbContext _context;
        public UsersController1(ApplicationDbContext context,UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<IdentityUser> signInManager)
        {
            _roleManager = roleManager;
            _signInManager = signInManager;
            _userManager = userManager;
            _context= context;
        }
            public async Task<ActionResult> Index()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }
    }
}
