using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.XForms;

namespace EpiServerProject.Models.Blocks
{
    /// <summary>
    /// Used to insert an XForm
    /// </summary>
    [ContentType(DisplayName = "FormBlock", GUID = "8dee2ef5-2cd9-4183-b7e3-55caae68a5ee", Description = "")]
    public class FormBlock : SiteBlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [CultureSpecific]
        public virtual string Heading { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20)]
        [CultureSpecific]
        public virtual XForm Form { get; set; }
    }
}