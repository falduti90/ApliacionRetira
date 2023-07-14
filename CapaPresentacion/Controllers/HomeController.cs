using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidad;
using CapaNegocio;


namespace CapaPresentacion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Entrega()
        {
            List<Muelle> Lista = new List<Muelle>();
            Lista = new CN_Muelle().Listar();


            List<SelectListItem> items = Lista.ConvertAll
         (
                d =>
                {
                    return new SelectListItem()
                    {
                        Text = d.Descripcion.ToString(),
                        Value = d.IdMuelle.ToString(),
                   
                    };

                }
          );

            ViewBag.items = items;
            return View();
        }
        public ActionResult Turno()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ListarPendientes(string Muelle)
        {

            List<ControlPendientes> Lista = new List<ControlPendientes>();
            Lista = new CN_ControlPendientes().Listar(Muelle);

            return Json(new { data = Lista }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult ListarEntregadas(string Muelle)
        {


            List<ControlEntregadas> Lista = new List<ControlEntregadas>();
            Lista = new CN_ControlEntregadas().Listar(Muelle);

            return Json(new { data = Lista }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult ListarCabecera(string Muelle)
        {

            List<ControlCabecera> Lista = new List<ControlCabecera>();
            Lista = new CN_ControlCabecera().Listar(Muelle);

            return Json(new { data = Lista }, JsonRequestBehavior.AllowGet);
        }

    }
}