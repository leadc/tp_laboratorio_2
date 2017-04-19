using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1___Calculadora
{
    class Calculadora
    {
        /// <summary>
        /// Opera dos numeros pasados por parametro según el operador ingresado.
        /// </summary>
        /// <param name="numero1">Primer operando.</param>
        /// <param name="numero2">Segundo operando.</param>
        /// <param name="operador">Operación a realizar.</param>
        /// <returns>Retorna el resultado en caso de exito o cero en caso de error.</returns>
        public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            double result=0;
            switch(Calculadora.validarOperador(operador))
            {
                case "+":
                    result = numero1.getNumero() + numero2.getNumero();
                    break;
                case "-":
                    result = numero1.getNumero() - numero2.getNumero();
                    break;
                case "*":
                    result = numero1.getNumero() * numero2.getNumero();
                    break;
                case "/":
                    if (numero2.getNumero() != 0)
                        result = numero1.getNumero() / numero2.getNumero();
                    break;
            }
            return result;
        }
        /// <summary>
        /// Verifica que el operador sea correcto y lo devuelve en caso de exito, sino devuelve el operador "+" por defecto.
        /// </summary>
        /// <param name="operador">Operador a verificar.</param>
        /// <returns>Devuelve el opearador o "+" en caso de error.</returns>
        public static string validarOperador(string operador)
        {
            if (!(operador == "+" || operador == "-" || operador == "*" || operador == "/"))
                operador = "+";
            return operador;
        }
    }
}
