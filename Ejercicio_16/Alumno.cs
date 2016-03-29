using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_16
{
    class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        /// <summary>
        /// Asigna las notas del alumno.
        /// </summary>
        /// <param name="notaUno">
        /// Primera nota a asignar.
        /// </param>
        /// <param name="notaDos">
        /// Segunda nota a asignar.
        /// </param>
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        /// <summary>
        /// Calcula el resultado que tendra el final del alumno,
        /// </summary>
        public void CalcularFinal()
        {
            Random rand = new Random();
            if (this._nota1 >= 4 && this._nota2 >= 4)
                this._notaFinal = rand.Next(1, 10);
            else
                this._notaFinal = -1;
        }

        /// <summary>
        /// Muestra los datos del alumno.
        /// </summary>
        public void Mostrar()
        {
            Console.WriteLine("Apellido: {0}", this.apellido);
            Console.WriteLine("Nombre: {0}", this.nombre);
            Console.WriteLine("Legajo: {0}", this.legajo);
            Console.WriteLine("Nota 1: {0}", this._nota1);
            Console.WriteLine("Nota 2: {0}", this._nota2);
            if (this._notaFinal != -1)
                Console.WriteLine("Nota Final: {0}", this._notaFinal);
            Console.WriteLine("");
        }
    }
}
