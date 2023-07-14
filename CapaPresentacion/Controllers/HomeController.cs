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

        // Metodo  que  combierte los datos  en un selectlistitem para poder mostrarlo en la vista.
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

        // Metodo  que devuelve Jsonresult que  se usa en la vista de entrega.
        // Esto permite poder llenar la tabla de pendietes que  esta declara en dicha vista
        [HttpGet]
        public JsonResult ListarPendientes(string Muelle)
        {

            List<ControlPendientes> Lista = new List<ControlPendientes>();
            Lista = new CN_ControlPendientes().Listar(Muelle);

            return Json(new { data = Lista }, JsonRequestBehavior.AllowGet);
        }


        // Metodo  que devuelve Jsonresult que  se usa en la vista de entrega.
        // Esto permite poder llenar la tabla de Entregadas que  esta declara en dicha vista.
        [HttpGet]
        public JsonResult ListarEntregadas(string Muelle)
        {


            List<ControlEntregadas> Lista = new List<ControlEntregadas>();
            Lista = new CN_ControlEntregadas().Listar(Muelle);

            return Json(new { data = Lista }, JsonRequestBehavior.AllowGet);
        }

        // Metodo  que devuelve Jsonresult que  se usa en la vista de entregas.
        // Esto permite poder llenar  la cabecera que  esta declara en dicha vista.
        [HttpPost]
        public JsonResult ListarCabecera(string Muelle)
        {

            List<ControlCabecera> Lista = new List<ControlCabecera>();
            Lista = new CN_ControlCabecera().Listar(Muelle);

            return Json(new { data = Lista }, JsonRequestBehavior.AllowGet);
        }

    }
}