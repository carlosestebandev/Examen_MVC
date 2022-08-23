using System;
using System.Collections.Generic;

#nullable disable

namespace Examen_UPC_MVC_Carlos_Ramos.Models
{
    public partial class TbAlumno
    {
        public TbAlumno()
        {
            TbSolicituds = new HashSet<TbSolicitud>();
        }

        public int IdAlumno { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public virtual ICollection<TbSolicitud> TbSolicituds { get; set; }
    }
}
