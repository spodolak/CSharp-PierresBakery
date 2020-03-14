using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Vendor
  {
    public string Name {get;set;}
    public string Description {get;set;}
    public int Id {get;set;}
    public static List<Vendor> Vendors = new List<Vendor> {};
    public List<Order> Orders {get;set;}

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Vendors.Add(this);
      Id = Vendors.Count;
      Orders = new List <Order>{};
    }

    public static List<Vendor> GetAll()
    {
      return Vendors;
    }

    public static Vendor Find(int searchId)
    {
      return Vendors[searchId-1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}