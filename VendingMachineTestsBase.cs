using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendingMachine
{
    [TestClass]
    public abstract class VendingMachineTestsBase
    {
        public abstract void InsertCoin_ValidCoin_DisplayIsUpdated();
    }
}