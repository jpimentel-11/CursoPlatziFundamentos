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
            Console.WriteLine(escuela);
            Console.WriteLine(escuela);
        }
    }
}
  