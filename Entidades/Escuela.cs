namespace coreEscuela.Entidades
{
    class Escuela
    {

      public string Nombre {get; set;}
      public int AñoDeCreacion{get;set;}

      public string Pais {get; set;}
      public string Ciudad {get; set;}   
      public TiposEscuela TipoEscuela {get;set;}

      public Curso[] cursos {get;set;}

      public Escuela(string nombre, int año) => (Nombre,AñoDeCreacion) =(nombre,año);

      public Escuela(string nombre,int año,TiposEscuela tipos, string pais="", string ciudad="")
      {
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