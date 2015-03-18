using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMS.ViewModel.Factory;
using TMS.ViewModel.InterfaceBase.ConcreteInterface;

namespace UnitTestTMS.Factory
{
    [TestClass]
    public class UnitTestFactory
    {
        [TestMethod]
        public void TestMethodFactory()
        {
            ITransportConcrete iTransportobj =
                ViewModelFactory.ExecuteFactory<ITransportConcrete>(ViewModelFactory.ConcreteSelector.Transport);

            Assert.IsNotNull(iTransportobj);
        }
    }
}
