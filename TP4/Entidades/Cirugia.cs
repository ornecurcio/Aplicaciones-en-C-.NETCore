using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoCirugia(); 
    public class Cirugia
    {
        #region Atributos

        private Cirujano cirujano;
        private Paciente paciente;
        private EPatologia patologia;
        private EProcedimiento procedimiento; 
        private DateTime fecha;
        bool operado; 
        public event DelegadoCirugia operar; 
        #endregion
       
        #region Constructores
        public Cirugia():this(new Paciente(),DateTime.Now,new Cirujano(),EPatologia.Columna,EProcedimiento.Artrodecis)
        {
        }
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="paciente">paciente a ser operado</param>
        /// <param name="fecha">la fecha de la cirugia</param>
        /// <param name="cirujano">cirujano que lo opera</param>
        /// <param name="patologia">la patologia por la que se opera</param>
        /// <param name="procedimiento">el procedimiento que se realiza</param>
        public Cirugia(Paciente paciente, DateTime fecha, Cirujano cirujano, 
                       EPatologia patologia, EProcedimiento procedimiento) 
        {
            this.paciente = paciente;
            this.fecha = fecha;
            this.cirujano = cirujano;
            this.patologia = patologia;
            this.procedimiento = procedimiento;
            operar += paciente.PacienteOperado;
            operar += CirugiaRealizada;
            operar += ActualizarEstadisticaHospital;
            //operar += ActulizarEstadisticaCirujano;
            operar += CargarEnBaseDatos;
            
        }
        #endregion
        
        #region Propiedades
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
        #endregion
        public override string ToString()
        {
            return $"Paciente: {paciente.Apellido},{paciente.Nombre} -- Cirujano {cirujano.Apellido} -- Patologia: {patologia} -- Procedimiento: {procedimiento}";
        }
        public void CirugiaRealizada()
        {
            this.operado = true;
            Hospital.CirugiasPendientes.Remove(this);
            Hospital.SerializarCirugias(); 
        }
        
        public void ActualizarEstadisticaHospital()
        {
            Hospital.Estadistica.ActualizarPatologia(this.patologia);
            Hospital.Estadistica.ActualizarProcedimiento(this.procedimiento);
        }
        public void CargarEnBaseDatos()
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            accesoDatos.AgregarCirugia(this);
            Hospital.CirugiasRealizadas = accesoDatos.ObtenerListaCirugias(); 
        }
        public void RealizarOperacion()
        {
            this.operar.Invoke();
            Thread.Sleep(1000);
        }

    }
}
