using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cirugia
    {
        private Cirujano cirujano;
        private Paciente paciente;
        private EPatologia patologia;
        private EProcedimiento procedimiento; 
        private Estadistica estadistica;
        private DateTime fecha;

        public Cirujano Cirujano
        {
            get
            {
                return this.cirujano; 
            }
            set
            {
                if(value is not null)
                {
                    this.cirujano = value; 
                }
            }
        }
        public Cirugia(Paciente paciente, Estadistica estadistica, DateTime fecha, Cirujano cirujano, EPatologia patologia, EProcedimiento procedimiento)
        {
            this.paciente = paciente;
            this.estadistica = estadistica;
            this.fecha = fecha;
            this.cirujano = cirujano;
            this.patologia = patologia; 
            this.procedimiento = procedimiento;
        }
        public EProcedimiento Procedimiento
        {
            get
            {
                return this.procedimiento; 
            }
        }
        public EPatologia Patologia
        {
            get
            {
                return this.patologia;
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
