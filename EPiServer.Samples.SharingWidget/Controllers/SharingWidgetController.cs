using System.Web.Mvc;
using EPiServer.Samples.SharingWidget.BlockTypes;
using EPiServer.Shell;
using EPiServer.Web.Mvc;

namespace EPiServer.Samples.SharingWidget.Controllers
{
    public class SharingWidgetController : BlockController<SharingWidgetBlock>
    {
        public override ActionResult Index(SharingWidgetBlock blockData)
        {
            return PartialView(Paths.ToResource(this.GetType(), "Views/SharingWidget/SharingWidget.cshtml"), blockData);
        }
    }
}