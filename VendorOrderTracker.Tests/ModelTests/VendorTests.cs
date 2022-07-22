using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreateVendorInstance_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), "Vendor");
    }
  }
}