using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiServerProject.Models.Blocks
{
    [ContentType(DisplayName = "Carousel Block", GUID = "1352a01f-d7d1-4366-a990-f3b50bac2e76", Description = "")]
    public class CarouselBlock : SiteBlockData
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