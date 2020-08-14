using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SweetAndSavory.Models
{
  public class ApplicationUser : IdentityUser
  {
    public ApplicationUser() : base()
    {
      this.Flavors = new HashSet<ApplicationUserFlavor>();
    }
    public string NickName { get; set; }
    public ICollection<ApplicationUserFlavor> Flavors { get; set; }
  }
}