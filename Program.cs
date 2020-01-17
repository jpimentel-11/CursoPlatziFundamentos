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
            
            
            var curso1 =new Curso(){
                Nombre="101"
            };

             var curso2 =new Curso(){
                Nombre="201"
            };

             var curso3 =new Curso(){
                Nombre="301"
            };

            Console.WriteLine(escuela);
        }
    }
}
  