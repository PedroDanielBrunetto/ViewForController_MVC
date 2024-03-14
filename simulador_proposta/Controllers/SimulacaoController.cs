using Microsoft.AspNetCore.Mvc;
using simulador_proposta.Models;

namespace simulador_proposta.Controllers
{
    public class SimulacaoController : Controller
    {
        public IActionResult Index()
        {
            var model = new SimulacaoModel();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SimulacaoModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Create", model);
            }

            return View("Index", model);
        }

    }
}
