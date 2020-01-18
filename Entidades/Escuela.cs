using System;
using System.Collections.Generic;

namespace coreEscuela.Entidades
{
    public class Escuela
    {
     public string UniqueId {get; private set;} = Guid.NewGuid().ToString();

      public string Nombre {get; set;}
      public int AñoDeCreacion{get;set;}

      public string Pais {get; set;}
      public string Ciudad {get; set;}   
      public TiposEscuela TipoEscuela {get;set;}

      public List<Curso> cursos {get;set;}

      public Escuela(string nombre, int año) => (Nombre,AñoDeCreacion) =(nombre,año);

      public Escuela(string nombre,int año,TiposEscuela tipos, string pais="", string ciudad="")
      {
          //Asignación por tuplas
          (Nombre,AñoDeCreacion)=(nombre,año);
          Pais=Pais;
          Ciudad=ciudad;
      }

     public override string ToString()
      {
          return $"Nombre:{Nombre},Tipo:{TipoEscuela} \n Pais:{Pais}, Ciudad:{Ciudad}";
      }


    }
}