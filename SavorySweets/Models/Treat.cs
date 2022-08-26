using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SavorySweets.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }
    public string Name { get; set; }
    public int TreatId { get; set; }
  

    public virtual ICollection<TreatFlavor> JoinEntities { get; set; }
    public virtual ApplicationUser User { get; set; }  
  }
}