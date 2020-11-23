using Glass.Mapper.Sc;
using Sitecore.Feature.Header.Models;
using Sitecore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitecore.Feature.Header.Controllers
{
    public class HeaderController : SitecoreController
    {
        public ActionResult Index()
        {
            ISitecoreContext context = new SitecoreContext();
            var result = context.GetCurrentItem<IHeader>();

            return View(result);
        }
    }
}