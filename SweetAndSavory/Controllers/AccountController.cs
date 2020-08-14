using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using SweetAndSavory.Models;
using SweetAndSavory.ViewModels;

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
    public ActionResult Index()
    {
      return View();
    }
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
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }
  }
}