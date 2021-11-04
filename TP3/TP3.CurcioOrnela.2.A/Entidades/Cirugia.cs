﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cirugia//: ICirugia
    {
        private Cirujano cirujano;
        private Paciente paciente;
        private EPatologia patologia;
        private EProcedimiento procedimiento; 
        private DateTime fecha;
        //private bool realizoCirugia; 
        
        public Cirugia(Paciente paciente, DateTime fecha, Cirujano cirujano, 
                       EPatologia patologia, EProcedimiento procedimiento) //, bool realizoCirugia)
        {
            this.paciente = paciente;
            this.fecha = fecha;
            this.cirujano = cirujano;
            this.patologia = patologia;
            this.procedimiento = procedimiento;
            //this.realizoCirugia = realizoCirugia; 
        }
        //public bool RealizoCirugia
        //{
        //    get
        //    {
        //        return this.realizoCirugia; 
        //    }
        //    set
        //    {
        //        this.realizoCirugia = value; 
        //    }
        //}
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
       
        public EProcedimiento Procedimiento
        {
            get
            {
                return this.procedimiento; 
            }
            set
            {
                this.procedimiento = value; 
            }
        }
        public EPatologia Patologia
        {
            get
            {
                return this.patologia;
            }
            set
            {
                this.patologia = value; 
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
