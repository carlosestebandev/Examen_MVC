using System;
using System.Collections.Generic;

#nullable disable

namespace Examen_UPC_MVC_Carlos_Ramos.Models
{
    public partial class TbCurso
    {
        public TbCurso()
        {
            TbDetalleSolicituds = new HashSet<TbDetalleSolicitud>();
        }

        public int IdCurso { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int NroCreditos { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<TbDetalleSolicitud> TbDetalleSolicituds { get; set; }
    }
}
