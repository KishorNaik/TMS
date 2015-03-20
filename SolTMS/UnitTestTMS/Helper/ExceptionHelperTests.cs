using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestTMS.Helper
{
    [TestClass()]
    public class ExceptionHelperTests
    {
        [TestMethod()]
        public async Task ExceptionHandlingTest_True()
        {
            Boolean Flag = false;
            await ExceptionHelper.ExceptionHandlingAsync(
                () =>
                {
                      int i = 20;
                      int j = 0;

                      var Result = i / j;
                    Debug.WriteLine(Result);
                },
                () =>
                {
                    Flag = true;
                    
                });

            Assert.IsTrue(Flag);
        }

        [TestMethod()]
        public async Task ExceptionHandlingTest_False()
        {
            Boolean Flag = false;
            await ExceptionHelper.ExceptionHandlingAsync(
                () =>
                {
                    int i = 20;
                    int j = 2;

                    var Result = i / j;
                    Debug.WriteLine(Result);
                    Flag = true;
                },
                () =>
                {
                   
                    Flag = false;

                });

            Assert.IsTrue(Flag);
        }

        [TestMethod()]
        public async Task ExceptionHandlingTest_Finally_True()
        {
            int Result = 0;
            await ExceptionHelper.ExceptionHandlingAsync(
                () =>
                {
                    int i = 20;
                    int j = 2;

                    Result = i / j;
                    Debug.WriteLine(Result);

                },
                () =>
                {
                    Result = 0;
                });

          
        }
    }
}
