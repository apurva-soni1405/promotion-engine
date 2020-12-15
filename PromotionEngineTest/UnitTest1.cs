using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngineUtility;
using System.Collections.Generic;

namespace PromotionEngineTest
{
    [TestClass]
    public class UnitTest1
    {
        ManageOrder manageOrder = new ManageOrder();

        [TestMethod]
        public void TestMethod1()
        {
            List<string> cart = new List<string>();
            cart.Add("A");

            int orderValue = manageOrder.CalculateOrder(cart);
            Assert.AreEqual(50, orderValue);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<string> cart = new List<string>();
            cart.Add("B");

            int orderValue = manageOrder.CalculateOrder(cart);
            Assert.AreEqual(30, orderValue);
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<string> cart = new List<string>();
            cart.Add("C");

            int orderValue = manageOrder.CalculateOrder(cart);
            Assert.AreEqual(20, orderValue);
        }

        [TestMethod]
        public void TestMethod4()
        {
            List<string> cart = new List<string>();
            cart.Add("D");

            int orderValue = manageOrder.CalculateOrder(cart);
            Assert.AreEqual(15, orderValue);
        }

        [TestMethod]
        public void TestMethod5()
        {
            List<string> cart = new List<string>();
            cart.Add("A");
            cart.Add("B");

            int orderValue = manageOrder.CalculateOrder(cart);
            Assert.AreEqual(80, orderValue);
        }

        [TestMethod]
        public void TestMethod6()
        {
            List<string> cart = new List<string>();
            cart.Add("A");
            cart.Add("C");

            int orderValue = manageOrder.CalculateOrder(cart);
            Assert.AreEqual(70, orderValue);
        }

        [TestMethod]
        public void TestMethod7()
        {
            List<string> cart = new List<string>();
            cart.Add("C");
            cart.Add("D");

            int orderValue = manageOrder.CalculateOrder(cart);
            Assert.AreEqual(30, orderValue);
        }

        [TestMethod]
        public void TestMethod8()
        {
            List<string> cart = new List<string>();
            cart.Add("A");
            cart.Add("B");
            cart.Add("C");

            int orderValue = manageOrder.CalculateOrder(cart);
            Assert.AreEqual(100, orderValue);
        }

        [TestMethod]
        public void TestMethod9()
        {
            List<string> cart = new List<string>();
            cart.Add("A");
            cart.Add("B");
            cart.Add("C");
            cart.Add("D");

            int orderValue = manageOrder.CalculateOrder(cart);
            Assert.AreEqual(110, orderValue);
        }

        [TestMethod]
        public void TestMethod10()
        {
            List<string> cart = new List<string>();
            cart.Add("A"); cart.Add("A"); cart.Add("A"); cart.Add("A"); cart.Add("A");
            cart.Add("B"); cart.Add("B"); cart.Add("B"); cart.Add("B"); cart.Add("B");
            cart.Add("C");          
            
            int orderValue = manageOrder.CalculateOrder(cart);
            Assert.AreEqual(370, orderValue);
        }

        [TestMethod]
        public void TestMethod11()
        {
            List<string> cart = new List<string>();
            cart.Add("A"); cart.Add("A"); cart.Add("A");
            cart.Add("B"); cart.Add("B"); cart.Add("B"); cart.Add("B"); cart.Add("B");
            cart.Add("C");
            cart.Add("D");

            int orderValue = manageOrder.CalculateOrder(cart);
            Assert.AreEqual(280, orderValue);
        }
    }
}
