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
        private int cantCirugiaPaciente;
        private int cantColumna;
        private int cantMiembroSuperior;
        private int cantMiembroInferior;
        private int cantPelvis;

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
        public int CantCirugiaPaciente
        {
            get
            {
                return this.cantCirugiaPaciente;
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

        public Estadistica()
        { }
        public void Actualizar(EPatologia patologia)
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
                default:
                    break;
            }
        }
    }
}
