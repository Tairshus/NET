using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContosoUniversity.Models;

namespace ContosoUniversity.CAD
{
    public class InicializadorEscuela : System.Data.Entity.DropCreateDatabaseIfModelChanges<EscuelaContext>
    {
        protected override void Seed(EscuelaContext context)
        {
            var estudiantes = new List<Estudiante>
            {
                new Estudiante{nombre="Catalina", apellido="Sandoval", fechaInscripcion=DateTime.Parse("17-04-2007")},
                new Estudiante{nombre="Luisa", apellido="Mendes", fechaInscripcion=DateTime.Parse("15-03-2002")},
                new Estudiante{nombre="Fernando", apellido="Villar", fechaInscripcion=DateTime.Parse("25-05-1999")},
                new Estudiante{nombre="Julian", apellido="Mc", fechaInscripcion=DateTime.Parse("13-06-1998")},
                new Estudiante{nombre="Javier", apellido="Fal", fechaInscripcion=DateTime.Parse("08-10-1996")},
                new Estudiante{nombre="Pamela", apellido="Macedo", fechaInscripcion=DateTime.Parse("12-04-1998")},
                new Estudiante{nombre="Franco", apellido="Arratia", fechaInscripcion=DateTime.Parse("20-07-2004")}
            };

            estudiantes.ForEach(s => context.Estudiantes.Add(s));
            context.SaveChanges();
            var cursos = new List<Curso>
            {
                new Curso{cursoID=30, titulo="Historia", creditos=8},
                new Curso{cursoID=403, titulo="Diseño Grafico", creditos=7},
                new Curso{cursoID=2001, titulo="Matematica", creditos=6},
                new Curso{cursoID=604, titulo="Botanica", creditos=9},
                new Curso{cursoID=1000, titulo="Mecanica", creditos=7},
                new Curso{cursoID=404, titulo="Contabilidad", creditos=10},
                new Curso{cursoID=89, titulo="Economia", creditos=2}
            };

            cursos.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();
            var inscripciones = new List<Inscripcion>
            {
                new Inscripcion{estudianteID=1, cursoID=30, grado=Grado.B},
                new Inscripcion{estudianteID=1, cursoID=403, grado=Grado.C},
                new Inscripcion{estudianteID=1, cursoID=2001, grado=Grado.B},
                new Inscripcion{estudianteID=2, cursoID=403, grado=Grado.B},
                new Inscripcion{estudianteID=3, cursoID=2001, grado=Grado.C},
                new Inscripcion{estudianteID=3, cursoID=89, grado=Grado.F},
                new Inscripcion{estudianteID=4, cursoID=2001, grado=Grado.F},
                new Inscripcion{estudianteID=4, cursoID=604, grado=Grado.A},
                new Inscripcion{estudianteID=5, cursoID=1000},
                new Inscripcion{estudianteID=6, cursoID=404, grado=Grado.A},
                new Inscripcion{estudianteID=6, cursoID=89, grado=Grado.B},
                new Inscripcion{estudianteID=6, cursoID=2001},
                new Inscripcion{estudianteID=7, cursoID=40}
            };
            inscripciones.ForEach(s => context.Inscripciones.Add(s));
            context.SaveChanges();
        }
    }
}