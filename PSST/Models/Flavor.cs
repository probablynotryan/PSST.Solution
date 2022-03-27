using System.Collections.Generic;

namespace Treats.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<FlavorSweet>();
    }

    public int FlavorId { get; set; }
    public string FlavorName { get; set; }

    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<FlavorSweet> JoinEntities { get; set; }
  }
}