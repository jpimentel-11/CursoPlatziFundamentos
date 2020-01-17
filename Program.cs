using System;
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
            
           escuela.cursos = new Curso[]{
                new Curso(){Nombre="101"},
                new Curso(){Nombre="201"},
                new Curso(){Nombre="301"}
            };

          /* Curso[] arregloCursos = {
                new Curso(){Nombre="101"},
                new Curso(){Nombre="201"},
                new Curso(){Nombre="301"}
            };*/

            Console.WriteLine(escuela);
           // escuela.cursos=null;
            ImprimirCursosEscuela(escuela);
            //ImprimirCursos(arregloCursos);
            
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
           WriteLine("==========================");
           WriteLine("Cursos de la escuela");
           WriteLine("==========================");
           if (escuela!=null & escuela.cursos==null)
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
  