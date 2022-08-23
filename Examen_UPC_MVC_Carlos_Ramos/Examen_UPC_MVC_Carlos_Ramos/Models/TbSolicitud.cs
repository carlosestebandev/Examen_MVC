using System;
using System.Collections.Generic;

#nullable disable

namespace Examen_UPC_MVC_Carlos_Ramos.Models
{
    public partial class TbSolicitud
    {
        public TbSolicitud()
        {
            TbDetalleSolicituds = new HashSet<TbDetalleSolicitud>();
        }

        public int IdSolicitud { get; set; }
        public int IdAlumno { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string CodRegistrante { get; set; }
        public string Carrera { get; set; }
        public string Periodo { get; set; }

        public virtual TbAlumno IdAlumnoNavigation { get; set; }
        public virtual ICollection<TbDetalleSolicitud> TbDetalleSolicituds { get; set; }
    }
}
