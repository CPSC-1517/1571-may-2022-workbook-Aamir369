using Microsoft.VisualStudio.TestTools.UnitTesting;
using RenoSystem;
using System;

namespace RenoUnitTestsEx1
{
    [TestClass]
    public class OpeningTests
    {
        [TestMethod]
        [DataRow(OpeningType.Door, 106, 204, 10 )]
        [DataRow(OpeningType.Window, 100, 120, 10)]
        [DataRow(OpeningType.Window, 106, 204)]

        public void CreateOpening_GoodOpening_OpeningMade(OpeningType type,int width = 0, int height = 0, int edging = 0)
        {
            try
            {
                Opening theOpening = new Opening(type, width, height, edging );
            }
            catch (Exception ex)
            {
                Assert.Fail($"Unexpected exception of type {ex.GetType()} caught {ex.Message}");
            }

        }

        [TestMethod]
        [DataRow(OpeningType.None)]
        [DataRow(OpeningType.None, 0, 0, 0)]
        [DataRow(OpeningType.None, 100, 120, 10)]
        [DataRow(OpeningType.None, 100, 120)]
        [DataRow(OpeningType.None, 100 )]

        public void CreateOpening_NoOpening_OpeningMade(OpeningType type, int width = 0, int height = 0, int edging = 0)
        {
            try
            {
                Opening theOpening = new Opening(type, width, height, edging);
                string expected = "None,0,0,0";
                string actual = theOpening.ToString();
                Assert.AreEqual(actual, expected, "None opening has non-zero measurements.");

            }
            catch (Exception ex)
            {
                Assert.Fail($"Unexpected exception of type {ex.GetType()} caught {ex.Message}");
            }

        }

        [TestMethod]
        [DataRow(OpeningType.Window, 0, 120, 10 )]
        [DataRow(OpeningType.Window, -10, 120, 10)]
        [DataRow(OpeningType.Window, 16, 120, 10)]
        [DataRow(OpeningType.Window, 106, 0, 10)]
        [DataRow(OpeningType.Window, 106, -10, 10)]
        [DataRow(OpeningType.Window, 106, 20, 10)]
        [DataRow(OpeningType.Window, 106, 120, -10)]
        [DataRow(OpeningType.Window, 106, 120, 1)]

        public void CreateOpening_BadOpening_ExceptionThrown(OpeningType type, int width = 0, int height = 0, int edging = 0)
        {
            try
            {
                Opening theOpening = new Opening(type, width, height, edging);
                Assert.Fail("Exception was expected and failed to be thrown.");
            }
            catch (ArgumentException argex)
            {
                Assert.IsTrue(argex.Message.Contains("positive")
                    || argex.Message.Contains("minimum"));
            }
            catch (Exception ex)
            {
                Assert.IsFalse(ex.Message.Contains("Assert.Fail"));
                Assert.IsTrue(ex.Message.Length > 0, "Exception contained no message.");
            }
        }

        [TestMethod]
        [DataRow(OpeningType.Window, 100, 120, 10 )]
        [DataRow(OpeningType.Window, 100, 120)]
        public void AreaPerimeterCheck_GoodCalculation(OpeningType type, int width = 0, int height = 0, int edging = 0 )
        {
            try
            {
                Opening theOpening = new Opening(type, width, height, edging);
                Assert.AreEqual(theOpening.Area, 12000, "Area did not calculate as expected.");
                Assert.AreEqual(theOpening.Perimeter, 440, "Perimeter did not calculate as expected.");

            }
            catch (Exception ex)
            {
                Assert.Fail($"Unexpected exception of type {ex.GetType()} caught {ex.Message}");
            }
        }
        [TestMethod]
        [DataRow(OpeningType.Window,100, 120, 10 )]
        public void Opening_ToStringDisplay_GoodDisplay(OpeningType type, int width = 0, int height = 0, int edging = 0)
        {
            try
            {
                Opening theOpening = new Opening(type, width, height, edging );
                
                    Assert.AreEqual(theOpening.ToString(), "Window,100,120,10", $"ToString {theOpening.ToString()} not as expected.");
                

            }
            catch (Exception ex)
            {
                Assert.Fail($"Unexpected exception of type {ex.GetType()} caught {ex.Message}");
            }
        }
    }
}