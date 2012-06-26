using System.Web.Mvc;
using EPiServer.Samples.ShareThis.BlockTypes;
using EPiServer.Web.Mvc;
using EPiServer.Shell;

namespace EPiServer.Samples.ShareThis.Controllers
{
    public class ShareThisController : BlockController<ShareThisBlock>
    {
        public override ActionResult Index(ShareThisBlock blockData)
        {
            return PartialView(Paths.ToResource(this.GetType(), "Views/ShareThis/ShareThis.cshtml"), blockData);
        }
    }
}