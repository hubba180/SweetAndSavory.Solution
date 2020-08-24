// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Identity;
using SweetAndSavory.Models;
// using System.Threading.Tasks;
using SweetAndSavory.ViewModels;
// using System.Security.Claims;

  
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;


namespace SweetAndSavory.Controllers
{
  public class AccountController : Controller
  {
    private readonly SweetAndSavoryContext _db; 
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    public AccountController(SweetAndSavoryContext db, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
      _db = db;
      _userManager = userManager;
      _signInManager = signInManager;
    }
    // public  async Task<ActionResult> Index()
    // {
    //   var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    //   var currentUser = await _userManager.FindByIdAsync(userId);
    //   ViewBag.UserFlavors = _db.Flavors.Where(entry => entry.FlavorId == );
    //   var userTreats = _db.Treats.Where(entry => entry.User.Id == currentUser.Id);
    //   return View(userTreats);
    // }
    public ActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register(RegisterViewModel newUser)
    {
      var user = new ApplicationUser { UserName = newUser.Email, NickName = newUser.NickName};
      IdentityResult result = await _userManager.CreateAsync(user, newUser.Password);

      if (result.Succeeded)
      {
        Microsoft.AspNetCore.Identity.SignInResult RegisterSignIn = await _signInManager.PasswordSignInAsync(newUser.Email, newUser.Password, isPersistent: true, lockoutOnFailure: false);
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }
    public ActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
        Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
        if (result.Succeeded)
        {
            return RedirectToAction("Index");
        }
        else
        {
            return View();
        }
    }
    [HttpPost]
    public async Task<ActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index");
    }
  }
}