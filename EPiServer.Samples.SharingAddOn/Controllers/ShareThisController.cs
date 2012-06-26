using System.Web.Mvc;
using EPiServer.Samples.SharingAddOn.BlockTypes;
using EPiServer.Shell;
using EPiServer.Web.Mvc;

namespace EPiServer.Samples.SharingAddOn.Controllers
{
    public class ShareThisController : BlockController<ShareThisBlock>
    {
        public override ActionResult Index(ShareThisBlock blockData)
        {
            return PartialView(Paths.ToResource(this.GetType(), "Views/ShareThis/ShareThis.cshtml"), blockData);
        }
    }
}