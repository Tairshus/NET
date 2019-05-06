using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Curso
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cursoID { get; set; }
        public string titulo { get; set; }
        public int creditos { get; set; }

        public virtual ICollection<Inscripcion> Inscripciones { get; set; }
    }
}