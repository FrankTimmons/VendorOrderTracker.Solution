using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

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
    public void OrderConstructor_CreateOrderInstance_Order()
    {
      Order newOrder = new Order("testOrder", "testDescription", 1, "testDate");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "testTitle";
      Order newOrder = new Order(title, "testDescription", 1, "testDate");
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string title = "testTitle";
      string description = "testDescription";
      Order newOrder = new Order(title, description, 1, "testDate");
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string title = "testTitle";
      string description = "testDescription";
      Order newOrder = new Order(title, description, 1, "testDate");
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_OrderList()
    {
      string title01 = "testTitle01";
      string title02 = "testTitle02";
      string description01 = "testDescription01";
      string description02 = "testDescription02";
      Order newOrder1 = new Order(title01, description01, 1, "testDate");
      Order newOrder2 = new Order(title02, description02, 1, "testDate");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title01 = "testTitle01";
      string title02 = "testTitle02";
      string description01 = "testDescription01";
      string description02 = "testDescription02";
      Order newOrder1 = new Order(title01, description01, 1, "testDate");
      Order newOrder2 = new Order(title02, description02, 1, "testDate");
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}