using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiServerProject.Models.ViewModels
{
    public class BasicBlockModel
    {
      
        public virtual String Title { get; set; }

        
        public virtual XhtmlString TextBody { get; set; }
    }
}