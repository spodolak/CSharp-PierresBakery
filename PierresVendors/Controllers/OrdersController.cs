using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PierresVendors.Models;
using System;

namespace PierresVendors.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{Id}/orders/new")]
    public ActionResult New()
    {
      return View();
    }

   
  }
}