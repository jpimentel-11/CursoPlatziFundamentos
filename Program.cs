using System;
using coreEscuela.Entidades;

namespace Platzi2
{

    class Program
    {
        static void Main(string[] args)
        {
           
            var escuela =new Escuela("Platzi Academy",1997,TiposEscuela.primaria,ciudad:"Culiacán",pais:"México");
            escuela.TipoEscuela= TiposEscuela.primaria;
            

            var arregloCursos =new Curso[3];
            arregloCursos[0]= new Curso(){
                Nombre="101"
            };

            arregloCursos[1] =new Curso(){
                Nombre="201"
            };

            arregloCursos[2]=new Curso(){
                Nombre="301"
            };

            Console.WriteLine(escuela);
            ImprimirCursos(arregloCursos);
           
        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            //Recorriendo arreglo con for
          /*  System.Console.WriteLine("=================FOR===================");
             for(int i=0;i<arregloCursos.Length;i++)
            {
                Console.WriteLine("Nombre: "+arregloCursos[i].Nombre + ", Id: "+arregloCursos[0].UniqueId);
            }*/


            System.Console.WriteLine("=================FOR EACH===============");
            foreach(var curso in arregloCursos)
            {
                Console.WriteLine("Nombre: "+curso.Nombre + ", Id: "+curso.UniqueId);

            }
            
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
  