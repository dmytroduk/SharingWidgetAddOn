using System.Web.Mvc;
using EPiServer.Samples.SharingWidget.BlockTypes;
using EPiServer.Shell;
using EPiServer.Web.Mvc;

namespace EPiServer.Samples.SharingWidget.Controllers
{
    /// <summary>
    /// Sharing block template controller
    /// </summary>
    public class SharingWidgetBlockController : BlockController<SharingWidgetBlock>
    {
        /// <summary>
        /// Renders Sharing widget.
        /// </summary>
        /// <param name="currentBlock">Current Sharing block data.</param>
        /// <returns></returns>
        public override ActionResult Index(SharingWidgetBlock currentBlock)
        {
            // Hint for MVC to find the view in modules folder:
            return PartialView(Paths.ToResource(GetType(), "Views/SharingWidget/SharingWidget.cshtml"), currentBlock);
        }
    }
}