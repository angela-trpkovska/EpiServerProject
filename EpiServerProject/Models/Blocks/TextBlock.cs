using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiServerProject.Models.Blocks
{
    [ContentType(DisplayName = "TextBlock", GUID = "80ccd530-2399-4feb-b59c-df7f6468e5d7", Description = "")]
    public class TextBlock : SiteBlockData
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