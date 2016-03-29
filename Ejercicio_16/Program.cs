using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_16
{

    /* 
    16.  Crear la clase 'Alumno'.
    Se pide crear 3 instancias de la clase 'Alumno' (3 objetos), 
    colocarle nombre, apellido y legajo a cada uno de ellos.  
    Sólo se podrá ingresar las notas (nota1 y nota2) a través del 
    método Estudiar.  
    El método CalcularFinal deberá colocar la nota del final sólo si 
    las notas 1 y 2 son mayores o iguales a 4, caso contrario la 
    inicializará con -1. Para darle un valor a la nota final utilice 
    el método de instancia Next de la clase Random.  
    Por último, el método Mostrar, expondrá en la consola todos los 
    datos de los alumnos, a excepción de la nota final. Este valor se 
    mostrará sólo si es distinto de -1. 
    */

    class Ejercicio__16
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 16";

            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.apellido = "Romero";
            alumno2.apellido = "Alba";
            alumno3.apellido = "Araragi";

            alumno1.nombre = "Federico";
            alumno2.nombre = "Maka";
            alumno3.nombre = "Koyomi";

            alumno1.legajo = 123;
            alumno2.legajo = 52;
            alumno3.legajo = 15;

            alumno1.Estudiar(2, 10);
            alumno2.Estudiar(10, 10);
            alumno3.Estudiar(9, 9);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            alumno1.Mostrar();
            alumno2.Mostrar();
            alumno3.Mostrar();

            Console.ReadKey();
        }
    }
}