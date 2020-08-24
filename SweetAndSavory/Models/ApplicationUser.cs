using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SweetAndSavory.Models
{
  public class ApplicationUser : IdentityUser
  {
    public string NickName { get; set; }
  }
}