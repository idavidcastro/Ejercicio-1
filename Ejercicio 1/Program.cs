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
            double notaUno, notaDos, notaTres, promedioNotas=0;
            string opcionSeguir;

            do
            {
                
                Console.WriteLine("\nIngrese la nota 1 (RANGO: 0 a 5): ");
                try
                {
                    notaUno = double.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("ERROR!! La nota NO es correcta! Su valor será 1");
                    notaUno = 1;
                }

                while (notaUno < 0 || notaUno > 5)
                {
                    Console.WriteLine("Escriba un nota dentro del rango establecido (RANGO: 0 a 5): ");
                    try
                    {
                        notaUno = double.Parse(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("ERROR!! La nota NO es correcta! Su valor será 1");
                        notaUno = 1;
                    }
                }


                Console.WriteLine("Ingrese la nota 2 (RANGO: 0 a 5): ");
                try
                {
                    notaDos = double.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("ERROR!! La nota NO es correcta! Su valor será 1");
                    notaDos = 1;
                }

                while (notaDos < 0 || notaDos > 5)
                {
                    Console.WriteLine("Escriba un nota dentro del rango establecido (RANGO: 0 a 5): ");
                    try
                    {
                        notaDos = double.Parse(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("ERROR!! La nota NO es correcta! Su valor será 1");
                        notaDos = 1;
                    }
                }


                Console.WriteLine("Ingrese la nota 3 (RANGO: 0 a 5): ");
                try
                {
                    notaTres = double.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("ERROR!! La nota NO es correcta! Su valor será 1");
                    notaTres = 1;
                }

                while (notaTres < 0 || notaTres > 5)
                {
                    Console.WriteLine("Escriba un nota dentro del rango establecido (RANGO: 0 a 5): ");
                    try
                    {
                        notaTres = double.Parse(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("ERROR!! La nota NO es correcta! Su valor será 1");
                        notaTres = 1;
                    }
                }


                promedioNotas = (notaUno + notaDos + notaTres) / 3;
                Console.Write("El promedio de la asignatura es: {0}", promedioNotas);

                if (promedioNotas >= 3)
                {
                    Console.Write("\nEl estudiante GANÓ la asignatura");
                }
                else
                {
                    Console.Write("\nEl estudiante PERDIÓ la asignatura");
                }

                Console.Write("\n¿Desea volver a evaluar? S/N: ");
                opcionSeguir = Console.ReadLine();
            } while (opcionSeguir.ToUpper().Equals("S"));
 
        }
    }
}
