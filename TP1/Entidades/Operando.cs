using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        #region Atributos
        private double numero;
        #endregion
        #region Propiedades
        private string Numero
        {
            set 
            {
                this.numero = ValidarOperando(value);
            } 
        }
        #endregion
        #region Constructores
        /// <summary>
        /// Constructor por defecto, inicializa en 0
        /// </summary>
        public Operando() : this(0)
        { }
        /// <summary>
        /// Sobrecarga constructor con double
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Sobrecarga constructor con string
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        #endregion
        #region Validaciones
        /// <summary>
        /// Valida que el string recibido sea un numero
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>double si string valido, 0 si string no valido</returns>
        private double ValidarOperando(string strNumero)
        {
            if (Double.TryParse(strNumero, out double operando))
            {
                return operando;
            }
            return 0;
        }
        /// <summary>
        /// Valida si string recibido compuesto de 0 o 1
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>true si correcto, false si incorrecto</returns>
        private bool EsBinario(string binario)
        {
            if (!string.IsNullOrWhiteSpace(binario))
            {
                foreach (char item in binario)
                {
                    if (item != '0' && item != '1')
                    {
                        return false;
                        break;
                    }
                }
                return true;
            }
            return false;
        }
        #endregion
        #region Operadores
        /// <summary>
        /// Sobrecarga de operador -
        /// </summary>
        /// <param name="n1">tipo Operando</param>
        /// <param name="n2">tipo Operando</param>
        /// <returns>valor de operacion en double</returns>
        public static double operator -(Operando n1, Operando n2)
        {
           return (n1.numero-n2.numero); 
        }
        /// <summary>
        /// Sobrecarga de operador *
        /// </summary>
        /// <param name="n1">tipo Operando</param>
        /// <param name="n2">tipo Operando</param>
        /// <returns>valor de operacion en double</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return (n1.numero * n2.numero);
        }
        /// <summary>
        /// Sobrecarga de operador /
        /// </summary>
        /// <param name="n1">tipo Operando</param>
        /// <param name="n2">tipo Operando</param>
        /// <returns>valor de operacion en double, si divisor 0 valor minimo</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero != 0)
            {
                return (n1.numero / n2.numero);
            }
            return Double.MinValue;
        }
        /// <summary>
        /// Sobrecarga de operador +
        /// </summary>
        /// <param name="n1">tipo Operando</param>
        /// <param name="n2">tipo Operando</param>
        /// <returns>valor de operacion en double</returns>
        public static double operator +(Operando n1, Operando n2)
        {
           return n1.numero + n2.numero;
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Conversor de Binario a Decimal
        /// </summary>
        /// <param name="binario">tipo string</param>
        /// <returns>numero decimal convertido tipo string</returns>
        public string BinarioDecimal(string binario)
        {
            if (!String.IsNullOrWhiteSpace(binario) && EsBinario(binario))
            {
                double auxNum = 0;
                double auxPotencias = binario.Length - 1;                    
                foreach (char letra in binario)
                {
                    string auxStr = letra.ToString();
                    double.TryParse(auxStr, out double auxDigit);
                    auxNum += (auxDigit * Math.Pow(2, auxPotencias));
                    auxPotencias--;
                }
                int auxEnt = (int)Math.Abs(auxNum);
                return auxEnt.ToString();
            }
            return "Valor Invalido";
        }
        /// <summary>
        /// Conversor de Decimal a Binario 
        /// </summary>
        /// <param name="numero">tipo double</param>
        /// <returns>binario en string</returns>
        public string DecimalBinario(double numero) 
        {
            string binarioStr = string.Empty;
            int numAbs = (int)Math.Abs(numero);
            if (numAbs == 0) 
            {
                binarioStr = "0";
            }  
            while (numAbs > 0) 
            {
                binarioStr = (int)numAbs % 2 + binarioStr;
                numAbs = (int)numAbs / 2;
            }
            return binarioStr;
        }
        /// <summary>
        /// Conversor Decimal a Binario
        /// </summary>uso interno de DecimalBinario numerico
        /// <param name="numeroStr">numero recivido como string</param>
        /// <returns>Binario de tipo string</returns>
        public string DecimalBinario(string numeroStr)
        {
            if (Double.TryParse(numeroStr, out double numDecimal))
            {
                return DecimalBinario(numDecimal);
            }
            return "Valor Invalido";
        }
        #endregion
    }
}
