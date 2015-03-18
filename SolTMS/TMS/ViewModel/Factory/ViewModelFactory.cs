using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using TMS.ViewModel.Concrete.Module.Transport;
using TMS.ViewModel.InterfaceBase.ViewModelInterface;

namespace TMS.ViewModel.Factory
{
    public static class ViewModelFactory
    {
        #region Declaration

        // In tuple Object specify the type of Concrete class and Dal class to invoke object dynamically.
        private static Dictionary<ConcreteSelector,Tuple<Type,Type>> instanceConcreteDic = new Dictionary<ConcreteSelector,Tuple<Type,Type>>();

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
           Transport=0
        };

        #endregion

        #region Execute Factory

        private static void LoadConcreteType()
        {
            instanceConcreteDic.Add(ConcreteSelector.Transport,new Tuple<Type,Type>(typeof(TransportConcrete),typeof(TransportDal)));
           
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

            // Get class types based on Concrete selector.
            var tupleObj = instanceConcreteDic[ConcreteSelectorEnum];

            // Get concrete class type from tuple object.
            var typeofConcrete = tupleObj.Item1;

            // Get repository class from tuple object.
            var typeofDal = tupleObj.Item2;

            // Create an instance of Concrete class dynamically and create an instance of repository class object in concrete class constructor dynamically
            TIFactoryObj = (TIFactory) Activator.CreateInstance(typeofConcrete,Activator.CreateInstance(typeofDal));

            return TIFactoryObj;
        }

        #endregion

    }
}
