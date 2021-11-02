using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estadistica
    {
        private int cantCirugiaCirujano;
        private int cantCirugiaAyudante;
        private int cantColumna;
        private int cantMiembroSuperior;
        private int cantMiembroInferior;
        private int cantPelvis;

        public Estadistica()
        {
        }
        public int CantCirugiaCirujano
        {
            get
            {
                return this.cantCirugiaCirujano;
            }
        }
        public int CantCirugiaAyudante
        {
            get
            {
                return this.cantCirugiaAyudante;
            }
        }
        public int CantColumna
        {
            get
            {
                return this.cantColumna;
            }
        }
        public int CantMiembroSuperior
        {
            get
            {
                return this.cantMiembroSuperior;
            }
        }
        public int CantMiembroInferior
        {
            get
            {
                return this.cantMiembroInferior;
            }
        }
        public int CantPelvis
        {
            get
            {
                return this.cantPelvis;
            }
        }

       
        public void ActualizarPatologia(EPatologia patologia)
        {
            switch (patologia)
            {
                case EPatologia.Columna:
                    this.cantColumna++; 
                    break;
                case EPatologia.MiembroSuperior:
                    this.cantMiembroInferior++; 
                    break;
                case EPatologia.MiembroInferior:
                    this.cantMiembroInferior++; 
                    break;
                case EPatologia.Pelvis:
                    this.cantPelvis++; 
                    break;
            }
        }
        public void ActualizarRol(ERol rol)
        {
            switch (rol)
            {
                case ERol.Cirujano:
                    this.cantCirugiaCirujano++;
                    break;
                case ERol.Ayudante:
                    this.cantCirugiaAyudante++;
                    break; 
            }
        }
    }
}
