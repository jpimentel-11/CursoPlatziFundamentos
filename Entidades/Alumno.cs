using System;

namespace coreEscuela.Entidades
{
      public class Alumno
      {

          public string UniqueId {get;set;}
          public string Nombre {get;set;}

          public Alumno() => UniqueId = Guid.NewGuid().ToString();
      }
    
}