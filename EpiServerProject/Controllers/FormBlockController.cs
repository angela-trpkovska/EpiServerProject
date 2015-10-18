using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EpiServerProject.Models.Blocks;

namespace EpiServerProject.Controllers
{
    public class FormBlockController : BlockController<FormBlock>
    {
        public override ActionResult Index(FormBlock currentBlock)
        {
            //return PartialView(currentBlock);
            return PartialView(string.Format("~/Views/Shared/Blocks/{0}.cshtml", currentBlock.GetOriginalType().Name), currentBlock);
        }
    }
}
