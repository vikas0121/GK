using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BLL;
using PropertyLayer;

namespace GkServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Job" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Job.svc or Job.svc.cs at the Solution Explorer and start debugging.
    public class Job : IJob
    {
        public MasterData GetMasterData()
        {
            JobBll objJobBll = new JobBll();
            return objJobBll.GetMasterData();
        }
    }
}
