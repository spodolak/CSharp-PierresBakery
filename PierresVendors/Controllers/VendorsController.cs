using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierresVendors.Models;

namespace PierresVendors.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpPost("/vendors")]
    public ActionResult Create()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return RedirectToAction("Index");
    }
    
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}