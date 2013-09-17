using System.Web.Mvc;
using MultipleFormsInTheSameViewSample.Filters;
using MultipleFormsInTheSameViewSample.ViewModels;

namespace MultipleFormsInTheSameViewSample.Controllers
{
    public class MembershipController : Controller
    {
        [ImportModelStateFromTempData]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [IgnoreModelErrors("Login")]
        [ExportModelStateToTempData]
        public ActionResult Register(RegisterOrLoginViewModel user)
        {
            //Vamos forçar um erro, para testar a validação
            ModelState.AddModelError("RegisterEmail", "EmailInvalido");

            if (ModelState.IsValid)
                return RedirectToAction("Success");

            return RedirectToAction("Index");
        }

        [HttpPost]
        [IgnoreModelErrors("Register")]
        [ExportModelStateToTempData]
        public ActionResult Login(RegisterOrLoginViewModel user)
        {
            //Vamos forçar um erro, para testar a validação
            ModelState.AddModelError("LoginEmail", "EmailInvalido");

            if (ModelState.IsValid)
                return RedirectToAction("Success");

            return RedirectToAction("Index");
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}
