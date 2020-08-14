using System.Collections.Generic;

namespace SweetAndSavory.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new HashSet<FlavorTreat>();
      this.ApplicationUsers = new HashSet<ApplicationUserFlavor>();
    }
    public int FlavorId { get; set; }
    public string Description { get; set; }
    public ICollection<FlavorTreat> Treats { get; set; }
    public ICollection<ApplicationUserFlavor> ApplicationUsers { get; set; }
  }
}