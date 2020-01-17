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
           // escuela.cursos.Add(tmp);
            ImprimirCursosEscuela(escuela);
            //WriteLine("Curso.Hash "+ tmp.GetHashCode());
            //escuela.cursos.Remove(tmp);
            escuela.cursos.RemoveAll((cur)=> cur.Nombre =="501" && cur.Jornada == TiposJornada.mañana);
            ImprimirCursosEscuela(escuela);

              /* private static bool Predicado(Curso curobj)
            {
                  return curobj.Nombre=="301";
            }*/

            /*  escuela.cursos.RemoveAll(delegate (Curso cur)
            {
                return cur.Nombre=="301";
            }); */


         /*  escuela.cursos = new Curso[]{
                new Curso(){Nombre="101"},
                new Curso(){Nombre="201"},
                new Curso(){Nombre="301"}
            };*/

           /* bool rta =10 ==20;
            int cantidad=10;

            if (cantidad>5 && rta ==false)
            {
                WriteLine("Se cumplio la condicion #1");
            }

            if (cantidad>5 && rta==false)
            {
                WriteLine("se cumplio la condicion #2");
            }

          Curso[] arregloCursos = {
                new Curso(){Nombre="101"},
                new Curso(){Nombre="201"},
                new Curso(){Nombre="301"}
            };*/

            //Console.WriteLine(escuela);
           // escuela.cursos=null;  
            //ImprimirCursos(arregloCursos);
            
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

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            //Recorriendo arreglo con for
          /*  System.Console.WriteLine("=================FOR===================");
             for(int i=0;i<arregloCursos.Length;i++)
            {
                Console.WriteLine("Nombre: "+arregloCursos[i].Nombre + ", Id: "+arregloCursos[0].UniqueId);
            }*/


          /*  System.Console.WriteLine("=================FOR EACH===============");
            foreach(var curso in arregloCursos)
            {
                Console.WriteLine("Nombre: "+curso.Nombre + ", Id: "+curso.UniqueId);

            }*/
            
           /* var contador=0;
            //Recorriendo arreglo con While
            System.Console.WriteLine("=================WHILE===================");
            while(contador<arregloCursos.Length)
            {
                Console.WriteLine("Nombre: "+arregloCursos[contador].Nombre + ", Id: "+arregloCursos[contador].UniqueId);
                contador++;
            }

            //Recorriendo arreglo con dowhile
            System.Console.WriteLine("================DO WHILE====================");
            contador=0;
            do
            {
                Console.WriteLine("Nombre: "+arregloCursos[contador].Nombre + ", Id: "+arregloCursos[contador].UniqueId);
                contador++;
            }while(contador<arregloCursos.Length);
           */
        }
    }
}
  