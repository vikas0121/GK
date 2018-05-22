using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyLayer;
using Dal;

namespace BLL
{
    public class JobBll
    {
        public MasterData GetMasterData()
        {
            try
            {
                JobDal obJobDal = new JobDal();
                return obJobDal.GetMasterData();
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
    }
}
