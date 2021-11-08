using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Cirujano))]
    [XmlInclude(typeof(Paciente))]
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private double dni;

        public Persona()
        { }
        public Persona(string nombre, string apellido, double dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        public string Nombre
        {
            get 
            { 
                return this.nombre;  
            }
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    this.nombre = value; 
                }
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.apellido = value;
                }
            }
        }
        public double Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (value>7000000 && value<99999999)
                {
                    this.dni = value;
                }
            }
        }
        
    }
}
