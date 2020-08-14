using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SweetAndSavory.Models;
using System.Threading.Tasks;
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
    public  ActionResult Index()
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