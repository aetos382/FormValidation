namespace FormValidation.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using FormValidation.Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return this.View();
        }

        public ActionResult Post()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Post(
            [Required] PostModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            return this.RedirectToAction("Post");
        }
    }
}