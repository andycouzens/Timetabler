using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using Timetabler.Entitities;

namespace Timetabler.WCF
{
    [ServiceContract]
    public interface IEventsService
    {
        [OperationContract]
        Task<List<Event>> GetEvents();
    }
}
