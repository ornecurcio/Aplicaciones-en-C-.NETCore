using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;
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
        public Operando() : this(0)
        { }
        public Operando(double numero)
        {
            this.numero = numero;
        }
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        #endregion
        #region Validaciones
        private double ValidarOperando(string strNumero)
        {
            if (Double.TryParse(strNumero, out double operando))
            {
                return operando;
            }
            return 0;
        }
        private bool EsBinario(string binario)
        {
            if (!String.IsNullOrEmpty(binario))
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
        public static double operator -(Operando n1, Operando n2)
        {
           return (n1.numero-n2.numero); 
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return (n1.numero * n2.numero);
        }
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero != 0)
            {
                return (n1.numero / n2.numero);
            }
            return Double.MinValue;
        }
        public static double operator +(Operando n1, Operando n2)
        {
           return n1.numero + n2.numero;
        }
        #endregion
        #region Metodos
        public string BinarioDecimal(string binario)
        {
            if (!String.IsNullOrEmpty(binario) && EsBinario(binario))
            {
                double auxNum = 0;
                double auxPotencias = binario.Length - 1;                    
                foreach (char letra in binario)
                {
                    string auxStr = letra.ToString();
                    double.TryParse(auxStr, out double auxDigit);
                    auxNum += (auxNum * Math.Pow(2, auxPotencias));
                    auxPotencias--;
                }
                int auxEnt = (int)Math.Abs(auxNum);
                return auxEnt.ToString();
            }
            return "Valor Invalido";
        }
        public string DecimalBinario(double numero) 
        {
            string binarioStr = "";
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
