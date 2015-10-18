using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;
using EPiServer;

namespace EpiServerProject.Models.Blocks
{
    /// <summary>
    /// Used to provide a composite property on the start page to set site logotype settings
    /// </summary>
    [ContentType(DisplayName = "SiteLogotypetBlock", GUID = "6ad2ad18-e6c7-4fa4-9329-ff070386ff3d",
      AvailableInEditMode = false)] // Should not be created and added to content areas by editors, the SiteLogotypeBlock is only used as a property type
    [SiteImageUrl]
    public class SiteLogotypeBlock : SiteBlockData
    {
        /// <summary>
        /// Gets the site logotype URL
        /// </summary>
        /// <remarks>If not specified a default logotype will be used</remarks>
        [DefaultDragAndDropTarget]
        [UIHint(UIHint.Image)]
        public virtual Url Url
        {
            get
            {
                var url = this.GetPropertyValue(b => b.Url);

                return url == null || url.IsEmpty()
                           ? new Url("/Static/gfx/logotype.png")
                           : url;
            }
            set
            {
                this.SetPropertyValue(b => b.Url, value);
            }
        }

        [CultureSpecific]
        public virtual string Title { get; set; }
    }
}