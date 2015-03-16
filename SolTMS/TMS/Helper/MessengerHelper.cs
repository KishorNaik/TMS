using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Helper
{
    public static class MessengerHelper
    {
        #region Declaration

        private static Dictionary<String, Object> dictioneryMessageObj = new Dictionary<String, object>();

        #endregion

        #region Methods

        public async static Task Send<TMessage>(String key, TMessage tMessageObj)
        {
            await Task.Run(async() =>
            {
                if (await Find(key) == false)
                {
                    dictioneryMessageObj.Add(key, tMessageObj);
                }
            });
        }

        public static Task<TMessage> Receive<TMessage>(String key)
        {
            return Task.Run(() => (TMessage)dictioneryMessageObj[key]);
        }

        public static Task Clear(String key)
        {
            return Task.Run(() =>dictioneryMessageObj.Remove(key) );
        }

        public static Task Clear()
        {
            return Task.Run(() => dictioneryMessageObj.Clear());
        }

        private static Task<Boolean> Find(String key)
        {
            return Task.Run(() => dictioneryMessageObj.ContainsKey(key));
        }

        #endregion
    }
}
