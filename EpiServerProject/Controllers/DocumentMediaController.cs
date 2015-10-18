using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using EpiServerProject.Models.Media;
using EpiServerProject.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpiServerProject.Controllers
{
    public class DocumentMediaController : PartialContentController<DocumentMedia>
    {
        private readonly UrlResolver _urlResolver;

        public DocumentMediaController(UrlResolver urlResolver)
        {
            _urlResolver = urlResolver;
        }

        /// <summary>
        /// The index action for the image file. Creates the view model and renders the view.
        /// </summary>
        /// <param name="currentContent">The current image file.</param>
        public override ActionResult Index(DocumentMedia currentContent)
        {
            var model = new DocumentViewModel
            {
                Url = _urlResolver.GetUrl(currentContent.ContentLink),
                Name = currentContent.Name,
                Copyright = currentContent.Copyright
            };

            return PartialView(model);
        }
    }
}