using System.Web.Mvc;
using MultipleFormsInTheSameViewSample.Models;

namespace MultipleFormsInTheSameViewSample.Controllers
{
    public class MembershipController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            return null;
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            return null;
        }
    }
}
