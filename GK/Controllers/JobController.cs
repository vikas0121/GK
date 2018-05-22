using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GK.JobService;

namespace GK.Controllers
{
    public class JobController : Controller
    {
        //
        // GET: /Job/
        public ActionResult JobListing()
        {
            return View();
        }

        public ActionResult PostJob()
        {
            JobService.JobClient objClient = new JobClient();
            MasterData objMasterData = objClient.GetMasterData();

            return View();
        }
	}
}