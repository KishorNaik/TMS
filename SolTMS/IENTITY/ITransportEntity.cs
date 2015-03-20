using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IENTITY
{
    public interface ITransportEntity
    {
        int? TransportId { get; set; }

        String TransportName { get; set; }

        String DriverName { get; set; }

        long MobileNo { get; set; }

        String VehicalNo { get; set; }

        Boolean IsDelete { get; set; }
    }
}
