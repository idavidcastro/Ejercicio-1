using System;

namespace Ejercicio_1
{
    class Program
    {
        /*
            Entrada: Tres notas a evaluar
            Proceso: Promedio de las notas y determinar 
            Salida: Determinar si el estudiante ganó o perdió la asignatura (LA NOTA MAYOR O IGUAL A 3 GANÓ; DE 
                    DE LO CONTRARIO, EL ESTUDIANTE PERDIÓ LA ASIGNATURA).
        */
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, promedio=0;
            string seguir;

            do
            {
                Console.WriteLine("\nIngrese la nota 1 (RANGO: 0 a 5): ");
                try
                {
                    nota1 = double.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("ERROR!! La nota NO es correcta! Su valor será 1");
                    nota1 = 1;
                }

                while (nota1 < 0 || nota1 > 5)
                {
                    Console.WriteLine("Escriba un nota dentro del rango establecido (RANGO: 0 a 5): ");
                    try
                    {
                        nota1 = double.Parse(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("ERROR!! La nota NO es correcta! Su valor será 1");
                        nota1 = 1;
                    }
                }


                Console.WriteLine("Ingrese la nota 2 (RANGO: 0 a 5): ");
                try
                {
                    nota2 = double.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("ERROR!! La nota NO es correcta! Su valor será 1");
                    nota2 = 1;
                }

                while (nota2 < 0 || nota2 > 5)
                {
                    Console.WriteLine("Escriba un nota dentro del rango establecido (RANGO: 0 a 5): ");
                    try
                    {
                        nota2 = double.Parse(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("ERROR!! La nota NO es correcta! Su valor será 1");
                        nota2 = 1;
                    }
                }


                Console.WriteLine("Ingrese la nota 3 (RANGO: 0 a 5): ");
                try
                {
                    nota3 = double.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("ERROR!! La nota NO es correcta! Su valor será 1");
                    nota3 = 1;
                }

                while (nota3 < 0 || nota3 > 5)
                {
                    Console.WriteLine("Escriba un nota dentro del rango establecido (RANGO: 0 a 5): ");
                    try
                    {
                        nota3 = double.Parse(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("ERROR!! La nota NO es correcta! Su valor será 1");
                        nota3 = 1;
                    }
                }


                promedio = (nota1 + nota2 + nota3) / 3;
                Console.Write("El promedio de la asignatura es: {0}", promedio);

                if (promedio >= 3)
                {
                    Console.Write("\nEl estudiante GANÓ la asignatura");
                }
                else
                {
                    Console.Write("\nEl estudiante PERDIÓ la asignatura");
                }

                Console.Write("\n¿Desea volver a evaluar? S/N: ");
                seguir = Console.ReadLine();
            } while (seguir.ToUpper().Equals("S"));

            
        }
    }
}
