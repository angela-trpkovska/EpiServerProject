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
    public class CarouselBlockController : BlockController<CarouselBlock>
    {
        public override ActionResult Index(CarouselBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
