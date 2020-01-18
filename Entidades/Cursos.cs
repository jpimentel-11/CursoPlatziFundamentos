using System;
using System.Collections.Generic;

namespace coreEscuela.Entidades
{
    public class Curso
    {
        public string UniqueId {get;set;}
        public string Nombre {get;set;}
        public TiposJornada Jornada {get;set;}

        public List<Asignatura> Asignaturas {get;set;}
        public List<Alumno> Alumnos {get;set;}
        public Curso()
        {
            //Genera un id unico para cada uno de los cursos
           UniqueId=Guid.NewGuid().ToString();
        }
        
    }
}