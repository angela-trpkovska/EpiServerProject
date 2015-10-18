using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EpiServerProject.Models.Blocks;
using EPiServer;
using EPiServer.Web;

namespace EpiServerProject.Models.Pages
{   
    /// <summary>
    /// Used for the site's start page and also acts as a container for site settings
    /// </summary>
    /// 
    [ContentType(DisplayName = "Start Page", GUID = "86191321-4c46-4c38-a789-80f6c4823182",
        Description = "", GroupName = Global.GroupNames.Specialized)]
    public class StartPage : SitePageData
    {
        [Display(Name = "Video", GroupName = SystemTabNames.Content, Order = 30)]
        [UIHint(UIHint.Video)]
        public virtual ContentReference Video { get; set; }

        [Display(Name = "Company logo", GroupName = Global.GroupNames.SiteSettings, Order = 40)]
        public virtual SiteLogotypeBlock SiteLogotype { get; set; }

        [Display(Name = "Copyright text",
            GroupName = Global.GroupNames.SiteSettings,
            Order = 50)]
        [CultureSpecific]
        public virtual string CopyrightsText { get; set; }

        [Display(Name = "Footer text",
            GroupName = Global.GroupNames.SiteSettings,
            Order = 60)]
        [CultureSpecific]
        public virtual string FooterText1 { get; set; }
    }
}