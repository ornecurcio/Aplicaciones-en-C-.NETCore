using System;
using Entidades;
using System.Collections.Generic; 

namespace ConsolaTP3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EPatologia> patologias = new List<EPatologia>();
            patologias.Add(EPatologia.Pelvis); 

            Paciente p1 = new Paciente("Camila", "Guerrero", 34707689, patologias);
            Console.WriteLine(p1);
            Cirujano c1 = new Cirujano("Ornela", "Curcio", 34707599, ERol.Cirujano, new Estadistica());
            Console.WriteLine(c1);
            Cirugia ciru1 = new Cirugia(p1, DateTime.Now, c1, EPatologia.Pelvis, EProcedimiento.Osteotomia);
            
            if(!Hospital.CargarCirujanos(c1))
            {
                Console.WriteLine("El metodo cargar cirujano funciona corretamente"); 
            }
            if(!Hospital.CargarPacientes(p1))
            {
                Console.WriteLine("El metodo cargar paciente funciona corretamente");
            }
            if(Hospital.CargarCirugia(ciru1))
            {
                Console.WriteLine("El metodo cargar cirugia funciona corretamente");
            }
            patologias.Add(EPatologia.MiembroSuperior); 
            if(Hospital.ActualizarPaciente(p1))
            {
                Console.WriteLine("El metodo actualizar paciente funciona corretamente");
            }

        }
    }
}
