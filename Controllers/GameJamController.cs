using Microsoft.AspNetCore.Mvc;
using GameJamRegistro.Models;

namespace GameJamRegistro.Controllers
{
    public class GameJamController : Controller
    {
        public IActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Jugador jugador)
        {
            if (jugador.PagoMatricula)
            {
                ViewBag.Mensaje = "Registro completado correctamente.";
            }
            else
            {
                ViewBag.Mensaje = "Usted aun no ha completado su pago.";
            }

            return View("Resultado");
        }
    }
}