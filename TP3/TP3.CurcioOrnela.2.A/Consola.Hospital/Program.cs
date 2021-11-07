using System;
using Entidades;
using System.Collections.Generic; 

namespace Consola.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Cirujano cirujano = new Cirujano("Ornela", "Curcio", 34707599, ERol.Cirujano, new Estadistica()); 
            
          
        }
    }
}
