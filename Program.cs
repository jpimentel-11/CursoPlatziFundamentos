using System;
using System.Collections.Generic;
using coreEscuela.Entidades;
using static System.Console;
using coreEscuela.Util;

namespace coreEscuela
{

    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            //Printer.DibujarLinea();
            Printer.WriteTitle("HELLO FUCKING WORLD!");
            ImprimirCursosEscuela(engine.Escuela);
        }
        private static void ImprimirCursosEscuela(Escuela escuela)
        {
          
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
  