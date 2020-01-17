using System;
using System.Collections.Generic;
using coreEscuela.Entidades;
using static System.Console;

namespace Platzi2
{

    class Program
    {
        static void Main(string[] args)
        {
           
            var escuela =new Escuela("Platzi Academy",1997,TiposEscuela.primaria,ciudad:"Culiacán",pais:"México");
            escuela.TipoEscuela= TiposEscuela.primaria;
            
            //Se creo la lista cursos con los grados: primero,segundo,tercero.
            //Una lista es un enum, objetos que se enumeran
            escuela.cursos =new List<Curso>(){
                new Curso(){Nombre="101"},
                new Curso(){Nombre="201"},
                new Curso(){Nombre="301"}
            };

            escuela.cursos.Add(new Curso(){Nombre="102",Jornada=TiposJornada.tarde});
            escuela.cursos.Add(new Curso(){Nombre="202",Jornada=TiposJornada.tarde});
            
            //Se creo una nueva coleccion con los cursos de los grados cuarto y quinto
            var otraColeccion =new List<Curso>(){
                new Curso(){Nombre="401",Jornada=TiposJornada.mañana},
                new Curso(){Nombre="501",Jornada=TiposJornada.mañana},
                new Curso(){Nombre="501",Jornada=TiposJornada.tarde},
                new Curso(){Nombre="502",Jornada=TiposJornada.tarde}
            }; 
            
            //Curso tmp = new Curso{Nombre="Vacional",Jornada=TiposJornada.noche};
            //Con AddRange se puede agregar una nueva colección a la colección ya existente
            //Con Add agregamos un nuevo curso(elemento) a la lista/colección
            ///Remove se utiliza p0ara eliminar un elemento especifico de la lista/colección
            escuela.cursos.AddRange(otraColeccion);
            ImprimirCursosEscuela(escuela);
            escuela.cursos.RemoveAll((cur)=> cur.Nombre =="501" && cur.Jornada == TiposJornada.mañana);
            ImprimirCursosEscuela(escuela);

            
        }
            private static void ImprimirCursosEscuela(Escuela escuela)
        {
           WriteLine("==========================");
           WriteLine("Cursos de la escuela");
           WriteLine("==========================");
           if (escuela!=null & escuela.cursos!=null)
           {
                foreach(var curso in escuela.cursos)
                {
                    WriteLine("Nombre: "+curso.Nombre + ", Id: "+curso.UniqueId);
                }
           }

        }
    }
}
  