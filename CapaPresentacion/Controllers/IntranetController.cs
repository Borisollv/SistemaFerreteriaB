using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidades;
using CapaAplicacion;

namespace CapaPresentacion.Controllers
{
    public class IntranetController : Controller
    {
        // GET: Intranet
        [HttpGet]
        public ActionResult MenuPrincipal(string msg)
        {
            ViewBag.msg = msg;
            return View();
        }
        [HttpGet]
        public ActionResult InicioSesion(string msg)

        {
            Session["empleado"] = null;
            ViewBag.msg = msg;
            return View();
        }

        [HttpPost]
        public ActionResult InicioSesion(FormCollection frm)
        {
            try
            {
                string usuario = Convert.ToString(frm["txtUsuario"]);
                string contrasena = Convert.ToString(frm["txtContrasena"]);
                Empleado empleado =logEmpleado.Instancia.VerificarInicioSesion(usuario, contrasena);
                if (empleado != null)
                {

                    Session["empleado"] = empleado;
                    return View("MenuPrincipal");
                }
                else { 
                    return RedirectToAction("InicioSesion","Intranet", new { msg = "El usuario o contraseña son incorrectas"});
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("InicioSesion", "Intranet", new { msg = ex.Message });

                
            }
           
        }
    }

}