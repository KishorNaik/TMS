using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTMS.Helper
{
    [TestClass()]
    public class MessengerHelperTests
    {
        [TestMethod()]
        public async Task SendReceiveTest()
        {
            await MessengerHelper.SendAsync<String>("x", "Get object");

            String Result = await MessengerHelper.ReceiveAsync<String>("x");

            Assert.AreEqual("Get object", Result);
        }

        [TestMethod()]
        public async Task RemoveTest()
        {
            await MessengerHelper.SendAsync<String>("x", "Get object");
            
            // Check if Key not found.
            //Boolean Flag = await MessengerHelper.RemoveAsync("xx");

            // Check if key found
            Boolean Flag = await MessengerHelper.RemoveAsync("x");

            Assert.IsTrue(Flag);

        }

        [TestMethod()]
        public async Task ClearTest()
        {
            try
            {
                await MessengerHelper.SendAsync<String>("x", "Get object");

                //
                await MessengerHelper.ClearAsync();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

        }

       

       
    }
}
