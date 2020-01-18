using System;
using System.Collections.Generic;
using System.Linq;
using coreEscuela.Entidades;


namespace coreEscuela
{
    public class EscuelaEngine
    {

         public Escuela Escuela {get;set;}

          public EscuelaEngine()
          {
               
          }

          public void Inicializar()
            {
                  Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.primaria,
                  ciudad: "Culiacaán", pais: "México");

                  CargarCursos();
                  CargarAsignatruras();
                  CargarEvaluaciones();
            }



            private void CargarEvaluaciones()
            {
                  throw new NotImplementedException();
            }

            private void CargarAsignatruras()
            {
                  foreach (var curso in Escuela.cursos)
                  {
                        List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                              new Asignatura(){Nombre="Matemáticas"},
                              new Asignatura(){Nombre="Educación física"},
                              new Asignatura(){Nombre="Castellano"},
                              new Asignatura(){Nombre="Ciencias Naturales"}  
                        };
                        curso.Asignaturas =listaAsignaturas;
                  }
            }

            private List<Alumno> CargarAlumnos(int cantidad)
            {
                  string[] nombre ={"Flavio","Jorge","Jazmin","Zulema","Flor"};
                  string[] apellido1= {"Valenzuela","Espinoza","Pimentel","Gracia","Nava"};
                  string[] nombre2 ={"Freddy","Anabel","Rick","Murty","Silvana"};

                  var listaAlumnos = from n1 in nombre
                                     from n2 in nombre2
                                     from a1 in apellido1
                                     select new Alumno{ Nombre=$"{n1} {n2} {a1}"};
                  
                  return listaAlumnos.OrderBy((al)=>al.UniqueId).Take(cantidad).ToList();
            }

            private void CargarCursos()
            { 
                 Escuela.cursos= new List<Curso>(){
                        new Curso(){Nombre="101",Jornada=TiposJornada.mañana},
                        new Curso(){Nombre="201",Jornada=TiposJornada.mañana},
                        new Curso(){Nombre="301",Jornada=TiposJornada.mañana},
                        new Curso(){Nombre="401",Jornada=TiposJornada.tarde},
                        new Curso(){Nombre="501",Jornada=TiposJornada.tarde}
                  };
                  Random rnd = new Random();
                  
                  foreach (var c in Escuela.cursos)
                  {
                        int cantRandom =rnd.Next(5,20);
                        c.Alumnos=CargarAlumnos(cantRandom);
                  }
             
            }
      }  
} 