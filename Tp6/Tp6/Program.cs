using System;
using System.Runtime.InteropServices;

namespace Tp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------ Ejercicio 1 del tp6--------------
            Console.WriteLine("Ingrese un numero Entero:");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 0)
            {
                int aux = numero;
                int invertido = 0;
                while (aux > 0)
                {
                invertido = (invertido * 10) + (aux % 10);
                aux = aux / 10;
                }
                Console.WriteLine("El numero ingresado es " + numero+ " y el numero invertido es " + invertido);
                
            }
            else
            {
                Console.WriteLine("No se puede invertir el numero " + numero);
            }
            //------------------------------------------------

            //------------------------------------Ejercicio 2 del tp6--------------------------------------------
            int opcion, num1, num2, resultado;
            char realizar;
            do
            {
                do
                {
                    Console.WriteLine("Ingrese la operacion que desea realizar:");
                    Console.WriteLine("1) Sumar, 2) Restar, 3) Multiplicar, 4) Dividir");
                    opcion = int.Parse(Console.ReadLine());
                } while (opcion < 1 || opcion > 4);

                Console.WriteLine("Ingrese dos numeros enteros:");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine("El resultado de la suma de los numeros es: " + resultado);
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine("El resultado de la resta de los numeros es: " + resultado);
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine("El resultado de la multiplicacion de los numeros es: " + resultado);
                        break;
                    default:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("El resultado de la division de los numeros es: " + resultado);
                        }
                        else
                        {
                            Console.WriteLine("No se puede hacer la division por 0");
                        }
                        break;
                }

                Console.WriteLine("Desea hacer otra operacion, ingrese s(SI) y n(NO)");
                realizar = char.Parse(Console.ReadLine());
            } while (realizar == 's');
            //--------------------------------------------------------------------------------------------------------

            //----------------------------------- Ejercicio 3 del tp 6------------------------------------------------
        }
    }
}
