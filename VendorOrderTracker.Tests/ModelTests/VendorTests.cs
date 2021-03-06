using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

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

    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      Vendor newVendor1 = new Vendor("goku", "he likes to train to be the strongest");
      Vendor newVendor2 = new Vendor("naruto", "hes gonna be hokage one day");
      List<Vendor> orderList = new List<Vendor> {newVendor1, newVendor2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(orderList, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      Vendor newVendor = new Vendor("naruto", "hes gonna be hokage one day");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      Vendor newVendor1 = new Vendor("goku", "he likes to train to be the strongest");
      Vendor newVendor2 = new Vendor("naruto", "hes gonna be hokage one day");
      Vendor result = Vendor.Find(1);
      Assert.AreEqual(newVendor1, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      Order orderOne = new Order("Wine", "A case of wine", 50, "3/3/2022");
      Order orderTwo = new Order("Beer", "A case of beer", 35, "3/4/2022");
      List<Order> newList = new List<Order> { orderOne };
      Vendor newVendor = new Vendor("naruto", "hes gonna be hokage one day");
      newVendor.AddItem(orderOne);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}