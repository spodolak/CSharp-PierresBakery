using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PierresVendors.Models;
using System;

namespace PierresVendors.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{Id}/orders/new")]
    public ActionResult New(int Id)
    {
      Vendor selectedVendor = Vendor.Find(Id);
      return View(selectedVendor);
    }
    [HttpGet("/vendors/{VendorId}/orders/{OrderId}")]
    public ActionResult Show(int VendorId, int OrderId)
    {
      Vendor selectedVendor = Vendor.Find(VendorId);
      Order selectedOrder = Order.Find(OrderId);
      return View(selectedOrder);
    }
  }
}