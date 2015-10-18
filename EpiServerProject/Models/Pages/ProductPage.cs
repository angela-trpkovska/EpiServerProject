using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EpiServerProject.Models.Blocks;

namespace EpiServerProject.Models.Pages
{
    [ContentType(DisplayName = "ProductPage", GUID = "e30eb139-0a47-41d7-af4c-da794c3fc5da", Description = "Page for the products")]
    public class ProductPage : SitePageData
    {
      [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [AllowedTypes(new[] { typeof(SteelShotTextBlock), typeof(CarouselBlock), typeof(ProductsImagesBlock)})]
        public virtual ContentArea MainBody { get; set; }

    }
}