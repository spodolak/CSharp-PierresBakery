using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Order
  {
    public string Title {get;set;}
    public string Description {get;set;}
    public int Price {get;set;}
    public int Date {get;set;}
    public int Id {get;set;}
    public static List<Order> Orders = new List<Order> {};


    public Order (string title, string description, int price, int date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      Orders.Add(this);
      Id = Orders.Count;
    }
    public static Order Find(int searchId)
    {
      return Orders[searchId-1];
    }
  }
}
