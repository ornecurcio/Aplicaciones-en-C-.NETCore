using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cirugia
    {
        private List<Cirujano> cirujanos;
        private Paciente paciente;
        private Dictionary<EPatologia, string> procedimientos;
        private Estadistica estadistica;
        private DateTime fecha;

        public List<Cirujano> Cirujanos
        {
            get
            {
                return this.cirujanos; 
            }
            set
            {
                if(value is not null)
                {
                    this.cirujanos = value; 
                }
            }
        }
        public Dictionary<EPatologia, string>Procedimientos
        {
            get
            {
                return this.procedimientos; 
            }
        }
        public Paciente Paciente
        {
            get
            {
                return this.paciente; 
            }
            set
            {
                if(value is not null)
                {
                    this.paciente = value; 
                }
            }
        }
        public Estadistica Estadistica
        {
            get
            {
                return this.estadistica;
            }
            set
            {
                if (value is not null)
                {
                    this.estadistica = value;
                }
            }
        }
        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }

    }
}
