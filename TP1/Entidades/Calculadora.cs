using System;

namespace Entidades
{
    public static class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return operador;
            }
            return '+';
        }
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double rta = 0;
            operador = ValidarOperador(operador);
            switch (operador)
            {
                case '+':
                    rta = num1 + num2;
                    break;
                case '-':
                    rta = num1 - num2;
                    break;
                case '/':
                    rta = num1 / num2;
                    break;
                case '*':
                    rta = num1 * num2;
                    break;
            }
            return rta;
        }
    }
}
