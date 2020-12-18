using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Tracker.Models;

namespace Tracker.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void OrderContructor_ItCreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    // public void Dispose()
    // {
      
    // }
  }
}