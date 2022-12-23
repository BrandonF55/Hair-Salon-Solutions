using System.Collections.Generic;
using MySqlConnector;


namespace HairSalon.Models
{

  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    public int StylistId { get; set;}
    public string Name { get; set; }
    public string Hired { get; set; }
    public virtual ICollection<Client> Clients { get; set;}

  }
}