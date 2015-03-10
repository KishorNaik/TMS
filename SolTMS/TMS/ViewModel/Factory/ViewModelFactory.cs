using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.ViewModel.InterfaceBase.ViewModelInterface;

namespace TMS.ViewModel.Factory
{
    public static class ViewModelFactory
    {
        #region Declaration

        // Store type of Concrete class.
        private static Dictionary<ConcreteSelector, Type> InstanceConcreteDic = new Dictionary<ConcreteSelector, Type>();

        #endregion

        #region Constructor

        static ViewModelFactory()
        {
            // Load Concrete class Type.
            LoadConcreteType();
        }
        #endregion

        #region Enum

        public enum ConcreteSelector
        {
           
        };

        #endregion

        #region Execute Factory

        private static void LoadConcreteType()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Execute factory 
        /// </summary>
        /// <typeparam name="TIFactory">Specify the type factory interface</typeparam>
        /// <param name="ConcreteSelectorEnum">Specify the name of concrete </param>
        /// <returns>Interface</returns>
        public static TIFactory ExecuteFactory<TIFactory>(ConcreteSelector ConcreteSelectorEnum)
        {
            TIFactory TIFactoryObj = default(TIFactory);

            // Create an instance of object bases on concrete class type which user specify the type of concrete class.
            TIFactoryObj =(TIFactory) Activator.CreateInstance(InstanceConcreteDic[ConcreteSelectorEnum]);

            return TIFactoryObj;
        }

        #endregion

    }
}
