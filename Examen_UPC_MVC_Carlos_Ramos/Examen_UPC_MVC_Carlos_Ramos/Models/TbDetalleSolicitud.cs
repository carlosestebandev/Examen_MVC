using System;
using System.Collections.Generic;

#nullable disable

namespace Examen_UPC_MVC_Carlos_Ramos.Models
{
    public partial class TbDetalleSolicitud
    {
        public int IdDetalleSol { get; set; }
        public int IdSolicitud { get; set; }
        public int IdCurso { get; set; }
        public string Profesor { get; set; }
        public string Aula { get; set; }
        public string Sede { get; set; }
        public string Observacion { get; set; }

        public virtual TbCurso IdCursoNavigation { get; set; }
        public virtual TbSolicitud IdSolicitudNavigation { get; set; }
    }
}
