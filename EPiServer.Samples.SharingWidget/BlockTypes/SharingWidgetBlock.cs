using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace EPiServer.Samples.SharingWidget.BlockTypes
{
    /// <summary>
    /// Sharing widget block type
    /// </summary>
    [ContentType(GUID = "A4242E8C-0FCC-4090-93D7-453EEEDA87DF")]
    public class SharingWidgetBlock : BlockData
    {
        /// <summary>
        /// Gets or sets the ShareThis publisher ID.
        /// </summary>
        /// <value>
        /// The publisher ID.
        /// </value>
        [Required]
        public virtual string PublisherId { get; set; }
    }
}