using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiServerProject.Models.Blocks
{
    [ContentType(DisplayName = "ProductsImagesBlock", GUID = "5c5e29f9-41e7-4cfd-9816-777686b2f02d", Description = "")]
    public class ProductsImagesBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Tiitle for the images in this area",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Products",
            Description = "Insert images that shoiuld exsist in this area",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        [AllowedTypes(new[] { typeof(ImageData) })]
        public virtual ContentArea Products { get; set; }
    }
}