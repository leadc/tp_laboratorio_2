using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1___Calculadora
{
    class Numero
    {
        private double _numero;
        /// <summary>
        /// Constructor que no recibe parámetros y establece el valor por defecto en cero para el atributo _numero.
        /// </summary>
        public Numero():this(0)
        {
        }
        /// <summary>
        /// Constructor que recibe un string con el contenido de un numero, si no es numero establece cero por defecto al atributo _numero.
        /// </summary>
        /// <param name="num">Numero a establecer en el atributo _numero</param>
        public Numero(string num):this()
        { 
            this.setNumero(num);
        }
        /// <summary>
        /// Constructor que recibe un numero y lo establece en el atributo _numero.
        /// </summary>
        /// <param name="num">Numero a establecer en el atributo _numero</param>
        public Numero(double num)
        {
            this._numero = num;
        }
        /// <summary>
        /// Valida que el string que ingresa por parámetro contenga un numero y lo devuelve en tipo double, en caso de que no contenga un numero, devuevle 0.
        /// </summary>
        /// <param name="numeroIngresado">String que contiene el numero a validar.</param>
        /// <returns>Retorna el numero validado o cero en caso de que no se haya ingresado un numero.</returns>
        private static double validarNumero(string numeroIngresado)
        {
            double ret = 0;
            double.TryParse(numeroIngresado, out ret);
            return ret;
        }
        /// <summary>
        /// Establece el numero pasado por parámetro (verificando que sea un numero, en caso de no serlo establece cero) en el atributo _numero.
        /// </summary>
        /// <param name="numero">Numero a ingresar</param>
        private void setNumero(string numero)
        {
            this._numero = Numero.validarNumero(numero);
        }
        /// <summary>
        /// Devuelve el numero contenido en el atributo _numero.
        /// </summary>
        /// <returns>Retorna el numero contenido en el atributo _numero.</returns>
        public double getNumero()
        {
            return this._numero;
        }

    }
}
