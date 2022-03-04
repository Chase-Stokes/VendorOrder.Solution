using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  
    public class OrderTests : IDisposable
    {

      public void Dispose()
      {
        Order.ClearAll();
      }
      [TestMethod]
      public void OrderConstructor_ChecksOrderObject_Strings()
      {
        string title = "Wine";
        string description = "A case of wine";
        int price = 50;
        string date = "3/4/2022";
        Order orderOne = new Order(title, description, price, date);
        Order orderTwo = new Order("Beer", "A case of beer", 35, "3/4/2022");
        string titleResult = orderOne.Title;
        string descriptionResult = orderOne.Description;
        int priceResult = orderOne.Price;
        string dateResult = orderOne.Date;
        Assert.AreEqual(title, titleResult);
        Assert.AreEqual(description, descriptionResult);
        Assert.AreEqual(price, priceResult);
        Assert.AreEqual(date, dateResult);
      }   

      [TestMethod]
      public void GetAll_ReturnsAllOrders_OrderList()
      {
        Order orderOne = new Order("Wine", "A case of wine", 50, "3/3/2022");
        Order orderTwo = new Order("Beer", "A case of beer", 35, "3/4/2022");
        List<Order> orderList = new List<Order> {orderOne, orderTwo};
        List<Order> result = Order.GetAll();
        CollectionAssert.AreEqual(orderList, result);
      }

      [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      Order orderOne = new Order("Wine", "A case of wine", 50, "3/3/2022");
      Order orderTwo = new Order("Beer", "A case of beer", 35, "3/4/2022");
      Order result = Order.Find(1);
      Assert.AreEqual(orderOne, result);
    }
  }
}