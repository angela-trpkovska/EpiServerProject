using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace EpiServerProject.Models.Blocks
{
    [ContentType(DisplayName = "InfoBlock", GUID = "247f027c-0f5f-4254-97e8-859bf31aab6e", Description = "")]
    public class InfoBlock : SiteBlockData
    {
        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [Display(
            Name = "Company Name",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual String CompanyName { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [Display(
            Name = "Company Address",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        [UIHint(UIHint.LongString)]
        public virtual String CompanyAddress { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [Display(
            Name = "Telephones",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        [UIHint(UIHint.LongString)]
        public virtual String CompanyTelephones { get; set; }
      
       [CultureSpecific]
        [Display(
            Name = "Fax",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual String CompanyFax { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [Display(
            Name = "Email",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        public virtual String CompanyEmail { get; set; }

    }
}