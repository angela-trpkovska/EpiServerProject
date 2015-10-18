using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace EpiServerProject.Models.Media
{
    [ContentType(DisplayName = "DocumentMedia", GUID = "4772218f-792a-4eb0-81d2-6054c8557cff", Description = "")]
    [MediaDescriptor(ExtensionString = "pdf,doc,docx")]
    public class DocumentMedia : MediaData
    {
            /// <summary>
            /// Gets or sets the copyright.
            /// </summary>
            /// <value>
            /// The copyright.
            /// </value>
            public virtual string Copyright { get; set; }
     }
}






