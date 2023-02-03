using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendingMachine
{
    [TestClass()]
    public class VendingMachineTests
    {
        [TestMethod()]
        public void InsertCoin_ValidCoin_DisplayIsUpdated()
        {
            // Arrange
            double currentCoin = 0.25;
            double expected = 0.25;

            // Act
            Program.InsertCoin(currentCoin);
            double actual = Convert.ToDouble(Program.CheckDisplay());

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PressButton_ValidProduct_DisplayIsUpdated()
        {
            // Arrange
            double currentProduct = 0.50;
            double expected = 0.50;

            // Act
            Program.PressButton(currentProduct);
            double actual = Convert.ToDouble(Program.CheckDisplay());

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
