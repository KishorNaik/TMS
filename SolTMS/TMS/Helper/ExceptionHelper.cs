using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Helper
{
    public static class ExceptionHelper
    {
        #region Methods

        public static Task ExceptionHandlingAsync(Action tryBlock, Action catchBlock,Action finallyBlock=null)
        {
            return Task.Run(() =>
            {
                try
                {
                    tryBlock();
                }
                catch (Exception)
                {
                    catchBlock();
                }
                finally
                {
                    if (finallyBlock != null) finallyBlock();
                }
            });
        }

        public static Task ExceptionHandlingAsync(Action tryBlock, Action<Exception> catchBlock, Action finallyBlock = null)
        {
            return Task.Run(() =>
            {
                try
                {
                    tryBlock();
                }
                catch (Exception ex)
                {
                    catchBlock(ex);
                }
                finally
                {
                    if (finallyBlock != null) finallyBlock();
                }
            });
        }


        public static Task<TReturnType> ExceptionHandlingAsync<TReturnType>(Func<TReturnType> tryBlock, Action catchBlock, Action finallyBlock = null)
        {
            return Task.Run(() =>
            {
                try
                {
                    return tryBlock();
                }
                catch (Exception)
                {
                    catchBlock();
                }
                finally
                {
                    if (finallyBlock != null) finallyBlock();
                }

                return default(TReturnType);
            });
            
        }

        public static Task<TReturnType> ExceptionHandlingAsync<TReturnType>(Func<TReturnType> tryBlock, Action<Exception> catchBlock, Action finallyBlock = null)
        {
            return Task.Run(() =>
            {
                try
                {
                    return tryBlock();
                }
                catch (Exception ex)
                {
                    catchBlock(ex);
                }
                finally
                {
                    if (finallyBlock != null) finallyBlock();
                }

                return default(TReturnType);
            });
        }
        #endregion
    }
}
