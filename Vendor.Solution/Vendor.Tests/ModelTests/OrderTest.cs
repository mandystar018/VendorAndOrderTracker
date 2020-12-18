using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Tracker.Models;

namespace Tracker.Tests
{
  [TestClass]
  public class OrderTests
   // public void Dispose()
    // {
      
    // }
  {

    [TestMethod]
    public void OrderContructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Bread", "Bread Special", 10, 12/18/20);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void Order_CreateOrderWithProperties_Order()
    {
      Order newOrder = new Order("Bread", "Bread Special", 10, 12/18/20);
      Assert.AreEqual("Bread", newOrder.Title);
      Assert.AreEqual("Bread Special", newOrder.Description);
      Assert.AreEqual(10, newOrder.Price);
      Assert.AreEqual(12/18/20, newOrder.Date);
    }
  }
}