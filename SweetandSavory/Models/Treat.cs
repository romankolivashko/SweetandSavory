using System.Collections.Generic;

namespace SweetandSavory.Models
{
  public class Item
  {
    public Item()
    {
      this.JoinEntities = new HashSet<CategoryItem>();
    }

    public int ItemId { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public virtual ApplicationUser User { get; set; }

    public virtual ICollection<CategoryItem> JoinEntities { get;}
  }
}