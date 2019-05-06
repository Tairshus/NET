using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public enum Grado
    {
        A, B, C, D, F
    }

    public class Inscripcion
    {
        public int instripcionID { get; set; }
        public int cursoID { get; set; }
        public int estudianteID { get; set; }
        public Grado? grado { get; set; }

        public virtual Curso curso { get; set; }
        public virtual Estudiante estudiante { get; set; }
    }
}