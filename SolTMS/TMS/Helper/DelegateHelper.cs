using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Helper
{
     public static class DelegateHelper
    {
        public static void Delegates(Action actionObj)
        {
            try
            {
                actionObj();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delegates<T>(T tObj, Action<T> actionObj)
        {
            try
            {
                actionObj(tObj);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static TReturn Delegates<TReturn>(Func<TReturn> funcObj)
        {
            TReturn tReturnObj = default(TReturn);
            try
            {
                tReturnObj = funcObj();
            }
            catch (Exception ex)
            {
                throw;
            }

            return tReturnObj;
        }

        public static TReturn Delegates<TReturn, T1, T2>(T1 t1Obj, T2 t2Obj, Func<T1, T2, TReturn> funcObj)
        {
            TReturn tReturnObj = default(TReturn);
            try
            {
                return tReturnObj = funcObj(t1Obj, t2Obj);
            }
            catch (Exception)
            {
                throw;
            }
        }
       
    }
}
