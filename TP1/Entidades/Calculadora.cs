using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que sea un operador matematico
        /// </summary>
        /// <param name="operador">a validar</param>
        /// <returns>operador validado o default +</returns>
        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return operador;
            }
            return '+';
        }
        /// <summary>
        /// Realiza la operacion matematica
        /// </summary>
        /// <param name="num1">tipo operando</param>
        /// <param name="num2">tipo operando</param>
        /// <param name="operador">operador matematico</param>
        /// <returns>resultado de operacion matematica en double</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;
            operador = ValidarOperador(operador);
            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
            }
            return resultado;
        }
    }
}
