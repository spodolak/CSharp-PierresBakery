using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Vendor
  {
    public string Name {get;set;}
    public string Description {get;set;}
    public static List<Vendor> Vendors = new List<Vendor> {};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
    }

    public static List<Vendor> GetAll()
    {
      return Vendors;
    }
  }
}