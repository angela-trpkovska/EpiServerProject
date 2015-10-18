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
    public class SteelShotTextBlockController : BlockController<SteelShotTextBlock>
    {
        public override ActionResult Index(SteelShotTextBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
