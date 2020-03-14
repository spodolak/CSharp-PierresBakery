using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Order
  {
    public string Description {get;set;}

    public Order (string description)
    {
      Description = description;
    }
  }
}