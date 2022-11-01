using Microsoft.AspNetCore.Mvc;
using CRUDCOREmvc.Datos;
using CRUDCOREmvc.Models;

namespace CRUDCOREmvc.Controllers
{
    public class MantenedorController : Controller
    {
        ContactoDatos _ContactoDatos = new ContactoDatos();
        public IActionResult Listar()
        {
            //LA VISTA MOSTRARA UNA LISTA DE CONTACTOS
            var oLista = _ContactoDatos.Listar();
            return View(oLista);
        }
        public IActionResult Guardar()
        {
            //METODO QUE SOLO DEVUELVE LA VISTA
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(ContactoModel oContacto)
        {
            //METODO QUE RECIBE EL OBJETO PARA GUARDARLO EN LE BASE DE DATOS

            if (!ModelState.IsValid)
                return View();

            bool respuesta = _ContactoDatos.Guardar(oContacto);
            if (respuesta)
                return RedirectToAction("Listar");
            else
            return View();
        }
        public IActionResult Editar(int IdContacto)
        {
            var oContacto = _ContactoDatos.Obtener(IdContacto);
            //METODO QUE SOLO DEVUELVE LA VISTA
            return View(oContacto);
        }

        [HttpPost]
        public IActionResult Editar(ContactoModel oContacto)
        {
            if (!ModelState.IsValid)
                return View();

            bool respuesta = _ContactoDatos.Editar(oContacto);
            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }
        public IActionResult Eliminar(int IdContacto)
        {
            var oContacto = _ContactoDatos.Obtener(IdContacto);
            //METODO QUE SOLO DEVUELVE LA VISTA
            return View(oContacto);
        }

        [HttpPost]
        public IActionResult Eliminar(ContactoModel oContacto)
        {
            bool respuesta = _ContactoDatos.Eliminar(oContacto.IdContacto);
            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }
    }
}
