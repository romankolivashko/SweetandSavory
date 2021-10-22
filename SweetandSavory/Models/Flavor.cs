using System.Collections.Generic;

namespace SweetandSavory.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<FlavorItem>();
    }

    public int FlavorId { get; set; }
    public string Name { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<FlavorItem> JoinEntities { get; set; }
  }
}