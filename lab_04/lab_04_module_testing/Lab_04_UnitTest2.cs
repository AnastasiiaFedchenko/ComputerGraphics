using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab_04; 
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Drawing.Printing;

namespace lab_04_module_testing
{
    [TestClass]
    public class Lab_04_UnitTest2
    {
        //[TestMethod]
        public void TestEllipseMethod(string path, Method method)
        { 
            List<line> expected = Lab_04_UnitTest1.read_from_file(path);

            Ellipse ellipse = new Ellipse(0, 0, 4, 3, Color.Black, Color.White);
            ellipse.controller(method, false);

            Assert.AreEqual(expected.Count, ellipse.Lines.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].P1.X, ellipse.Lines[i].P1.X);
                Assert.AreEqual(expected[i].P1.Y, ellipse.Lines[i].P1.Y);
                Assert.AreEqual(expected[i].P2.X, ellipse.Lines[i].P2.X);
                Assert.AreEqual(expected[i].P2.Y, ellipse.Lines[i].P2.Y);
            }   
        }
        [TestMethod]
        public void TestCircleCanonic()
        {
            string path = @"..\..\canonic_e.txt";
            TestEllipseMethod(path, Method.Canonic);
        }
        [TestMethod]
        public void TestCircleParametric()
        {
            string path = @"..\..\parametric_e.txt";
            TestEllipseMethod(path, Method.Parametric);
        }
        [TestMethod]
        public void TestCircleBresenham()
        {
            string path = @"..\..\bresenham_e.txt";
            TestEllipseMethod(path, Method.Bresenham);
        }
    }
}
