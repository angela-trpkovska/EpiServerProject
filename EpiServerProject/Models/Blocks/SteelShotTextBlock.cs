using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiServerProject.Models.Blocks
{
    [ContentType(DisplayName = "SteelShotTextBlock", GUID = "d14a2ffc-ffb4-4e6a-9fb9-4952f0d017ff", Description = "")]
    public class SteelShotTextBlock : SiteBlockData
    {
        [CultureSpecific]
        [Required]
        [Display(
            Name = "Title",
            Description = "Title of the block",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual String Title { get; set; }


        [CultureSpecific]
        [Required]
        [Display(
            Name = "Body",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString Body { get; set; }
    }
}