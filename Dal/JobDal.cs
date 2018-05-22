using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataHelper;
using PropertyLayer;

namespace Dal
{
    public class JobDal
    {
        public MasterData GetMasterData()
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(DbConnection.LivesqlConnection(), "[master].[GetMasterData]", null);
                if (ds != null && ds.Tables.Count > 0)
                {
                    var objMasterData = new MasterData();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        objMasterData.JobData = new List<JobDetails>();
                        foreach (DataRow row in ds.Tables[0].Rows)
                            objMasterData.JobData.Add(new JobDetails()
                            {
                                Id = row["Id"] == DBNull.Value ? 0 : Convert.ToInt32(row["Id"]), 
                                Title = row["PositionName"] == DBNull.Value ? "" : Convert.ToString(row["PositionName"]),
                            });
                    }
                    return objMasterData;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
    }
}
