using System.Web.Mvc;
using EpiServerProject.Models.Pages;
using EpiServerProject.Models.ViewModels;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace EpiServerProject.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);
            if (SiteDefinition.Current.StartPage.CompareToIgnoreWorkID(currentPage.ContentLink)) // Check if it is the StartPage or just a page of the StartPage type.
            {
                //Connect the view models logotype property to the start page's to make it editable
                var editHints = ViewData.GetEditHints<PageViewModel<StartPage>, StartPage>();
                editHints.AddConnection(m => m.Layout.Logotype, p => p.SiteLogotype);
                editHints.AddConnection(m => m.Layout.CopyrightsText, p => p.CopyrightsText);
                editHints.AddConnection(m => m.Layout.FooterText1, p => p.FooterText1);
            }
            return View(model);
        }
    }
}