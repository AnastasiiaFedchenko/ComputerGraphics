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
    public class Lab_04_UnitTest1
    {
        List<line> read_from_file(string path) 
        {
            int x1, y1, x2, y2;
            string text;
            string[] bits;
            List<line> expected = new List<line>();
            using (TextReader reader = File.OpenText(path))
            {
                text = reader.ReadLine();
                while (text != null)
                {
                    bits = text.Split(' ');
                    x1 = int.Parse(bits[0]);
                    y1 = int.Parse(bits[1]);
                    x2 = int.Parse(bits[2]);
                    y2 = int.Parse(bits[3]);
                    expected.Add(new line(x1, y1, x2, y2, Color.Black));
                    text = reader.ReadLine();
                }
            }
            return expected;
        }
        //[TestMethod]
        public void TestCircleMethod(string path, Method method)
        { 
            List<line> expected = read_from_file(path);

            Circle circle = new Circle(0, 0, 3, Color.Black, Color.White);
            circle.controller(method, false);

            Assert.AreEqual(expected.Count, circle.Lines.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].P1.X, circle.Lines[i].P1.X);
                Assert.AreEqual(expected[i].P1.Y, circle.Lines[i].P1.Y);
                Assert.AreEqual(expected[i].P2.X, circle.Lines[i].P2.X);
                Assert.AreEqual(expected[i].P2.Y, circle.Lines[i].P2.Y);
            }
        }
        [TestMethod]
        public void TestCircleCanonic()
        {
            string path = @"..\..\canonic.txt";
            TestCircleMethod(path, Method.Canonic);
        }
        [TestMethod]
        public void TestCircleParametric()
        {
            string path = @"..\..\parametric.txt";
            TestCircleMethod(path, Method.Parametric);
        }
        [TestMethod]
        public void TestCircleBresenham()
        {
            string path = @"..\..\bresenham.txt";
            TestCircleMethod(path, Method.Bresenham);
        }
    }
}
