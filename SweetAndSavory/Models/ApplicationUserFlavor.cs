namespace SweetAndSavory.Models
{
  public class ApplicationUserFlavor
  {
    public int ApplicationUserFlavorId { get; set; }
    public int FlavorId { get; set; }
    public Flavor Flavor { get; set; }
    public Treat Treat { get; set; }
  }
}