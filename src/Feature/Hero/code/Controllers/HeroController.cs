using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Feature.Hero.Models;
using System.Web.Mvc;

namespace Sitecore.Feature.Hero.Controllers
{
    public class HeroController : Controller
    {
        public ActionResult Show()
        {
            IMvcContext mvcContext = new MvcContext();
            
            HeroModel model = mvcContext.GetRenderingItem<HeroModel>();
            //HeroModel dsModel = mvcContext.GetDataSourceItem<HeroModel>();

            return View(model);
        }
    }
}