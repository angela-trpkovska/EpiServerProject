using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer;
using EPiServer.Web;

namespace EpiServerProject.Models.Pages
{
    [ContentType(DisplayName = "ContentPage", GUID = "a3e8cbe9-5ddf-4e0f-a27c-db19dc0102ef", Description = "")]
    public class ContentPage : SitePageData
    {
        [CultureSpecific]
        [Required]
        [Display(
            Name = "Title",
            Description = "Title for the text in the page",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Required]
        [Display(
            Name = "Text",
            Description = "Text that should appear on the page",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString Text { get; set; }

        [CultureSpecific]
        [Required]
        [Display(
            Name = "Link text",
            Description = "Text for the link for the document",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual string LinkText { get; set; }

        [CultureSpecific]
        [Required]
        [UIHint(UIHint.MediaFile)]
        [Display(
            Name = "Document link",
            Description = "Link to the document",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual ContentReference Document { get; set; }

        [CultureSpecific]
        [Required]
        [Display(
            Name = "Background image",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference BackgroundImage { get; set; }


    }
}