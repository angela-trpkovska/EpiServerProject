using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiServerProject.Models.Blocks
{
    [ContentType(DisplayName = "ProductionLineCarousel", GUID = "b54bf810-c73d-4f0c-bd5e-51dee6eb5de2", Description = "")]
    public class ProductionLineCarouselBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Carousel images",
            Description = "Insert images to show in the carousel",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual ContentArea Images { get; set; }
    }
}