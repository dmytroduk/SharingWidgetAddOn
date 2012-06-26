using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace EPiServer.Samples.SharingAddOn.BlockTypes
{
    [ContentType(DisplayName = "ShareThis Block", 
        Description = "Adds ShareThis widget on pages where block is placed.")]
    public class ShareThisBlock : BlockData
    {
        [Display(Name = "Publisher ID",
            Description = "Register on ShareThis.com to get your Publisher ID.")]
        [Required]
        public virtual string PublisherID { get; set; }
    }
}