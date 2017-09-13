using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UAC.Reports.Controllers
{
    using Models;

    public class RmasLabelController : Controller
    {
        [HttpGet]
        [Route("rmaslabel/{manifestnumber:int?}/{planttype:int?}")]
        public ActionResult Index(RmasLabelViewModel model = null)
        {
            return View(model ?? new RmasLabelViewModel());
        }
    }
}