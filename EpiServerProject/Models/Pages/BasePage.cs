using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using EpiServerProject.Models.Blocks;

namespace EpiServerProject.Models.Pages
{
    [ContentType(DisplayName = "BasePage", GUID = "0a0c30bc-48fa-4c0e-a82c-a4c100745efd", Description = "")]
    public class BasePage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [AllowedTypes(new[] { typeof(TextBlock), typeof(ProductionLineCarouselBlock), typeof(FormBlock), typeof(InfoBlock) })]
        public virtual ContentArea MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Background image",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference BackgroundImage { get; set; }

    }
}