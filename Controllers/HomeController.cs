using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using U2E1_18221800.Models;


namespace U2E1_18221800.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Mensaje([FromBody] Formulario formulario)
        {
            bool respuesta = true;
            if(formulario.NombreCompleto == "" || formulario.Correo == "" || formulario.Telefono == 0 || formulario.Motivo == "")
            {
                formulario.Respuesta = "Todos los campos son obligatorios";
                respuesta = false;
            }
            else
            {
                formulario.Respuesta = "Formulario Enviado. Pronto recibirá una respuesta";
                respuesta = true;
            }
            var resultado = new {respuesta = respuesta, mensaje = formulario.Respuesta };
            return Json(resultado);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}