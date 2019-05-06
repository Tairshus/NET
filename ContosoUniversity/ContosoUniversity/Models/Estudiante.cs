using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Estudiante
    {
        public int ID { get; set; }
        /*
        public int Id
        {
            set
            {
                ID = Id;
            }
            get
            {
                return Id;
            }
        }*/
        public string apellido { get; set; }
        public string nombre { get; set; }
        public DateTime fechaInscripcion { get; set; }

        public virtual ICollection<Inscripcion> Inscripciones { get; set; }
    }
}