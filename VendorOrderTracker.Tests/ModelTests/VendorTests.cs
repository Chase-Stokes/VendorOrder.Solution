using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void GetProperties_ReturnsProperties_Strings()
    {
      string name = "ed";
      string description = "ed has 2 friends named edd and eddie";
      Vendor newVendor = new Vendor(name, description);
      Vendor newVendor2 = new Vendor("naruto", "hes gonna be hokage one day");
      string nameResult = newVendor.Name;
      string descriptionResult = newVendor.Description;
      Assert.AreEqual(name, nameResult);
      Assert.AreEqual(description, descriptionResult);
    }
  }
}