using Examen_UPC_MVC_Carlos_Ramos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_UPC_MVC_Carlos_Ramos.Controllers
{
    public class SolicitudController : Controller
    {
        private readonly BD_PRUEBA_UPC_CARLOS_RAMOSContext _context;

        public SolicitudController(BD_PRUEBA_UPC_CARLOS_RAMOSContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET: Consulta Solicitud
        public async Task<IActionResult> ConsultaSolicitud(string periodo, DateTime fecha, string nombreAlumno)
        {
            var solicitudes = await _context.TbSolicituds.Include(c => c.IdAlumnoNavigation).ToListAsync();

            if (!String.IsNullOrEmpty(periodo))
            {
                solicitudes = solicitudes.Where(x => (x.Periodo).ToLower() == periodo.ToLower()).ToList();
            }



            if (fecha.Year != 1 )
            {
                solicitudes = solicitudes.Where(x => (x.FechaSolicitud.ToShortDateString()) == fecha.ToShortDateString()).ToList();
            }





            if (!String.IsNullOrEmpty(nombreAlumno))
            {
                solicitudes = solicitudes.Where(x => (x.IdAlumnoNavigation.Nombres + ' ' + x.IdAlumnoNavigation.Apellidos).ToLower().Contains(nombreAlumno.ToLower()) || x.IdAlumno.ToString() == nombreAlumno).ToList();

            }



            return View(solicitudes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BuscarSolicitud(int id, [Bind("Id,IdVenta,IdProducto,Cantidad")] TbSolicitud objSolicitud)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    var solicitudes = (IEnumerable<TbSolicitud>)_context.TbSolicituds.Include(c => c.IdAlumnoNavigation)
                        .Where(x => (x.IdAlumnoNavigation.Nombres + ' ' + x.IdAlumnoNavigation.Apellidos).Contains(objSolicitud.IdAlumnoNavigation.Nombres)).ToListAsync();

                    return View("ConsultaSolicitud", solicitudes);
                }
                return View("ConsultaSolicitud");
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
