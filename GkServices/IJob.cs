using PropertyLayer;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace GkServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IJob" in both code and config file together.
    [ServiceContract]
    public interface IJob
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetMasterData")]
        MasterData GetMasterData();
    }
}
