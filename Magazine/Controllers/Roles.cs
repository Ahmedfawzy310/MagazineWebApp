using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Magazine.Controllers
{
    [Authorize(Roles ="Admin")]
    public class Roles : Controller
    {
        RoleManager<IdentityRole> _roleManager;
        public Roles(RoleManager<IdentityRole> roleManager)
        {
            _roleManager=roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var roles=await _roleManager.Roles.ToListAsync();

            return View(roles);
        }

        [HttpPost]
        public async Task<IActionResult> Add(RoleFormViewModel model)
        {
           if(!ModelState.IsValid) 
                return View("Index", await _roleManager.Roles.ToListAsync());

           if(await _roleManager.RoleExistsAsync(model.Name))
            {
                ModelState.AddModelError("Name", "Role is exsit");
                return View("Index", await _roleManager.Roles.ToListAsync());
            }

            await _roleManager.CreateAsync(new IdentityRole(model.Name.Trim()));

            return RedirectToAction(nameof(Index));
        }


    }
}
