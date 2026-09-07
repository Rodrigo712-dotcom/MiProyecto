using System;
class Program
{
    static void Main()
    {
        String Nombre;
        String Respuesta = "si";

        while (Respuesta == "si")
        {
            Console.WriteLine("Hola, ¿Cuál es tu nombre? : ");
            Nombre = Console.ReadLine()!;

            if (Nombre != "")
            {
                Console.WriteLine("Hola " + Nombre + ", Bienvenido!!");
            }
            else
            {
                Console.WriteLine("No ingresaste un nombre.");
            }

            Console.WriteLine("¿Quieres Continuar?(s/n): ");
            Respuesta = Console.ReadLine()!;

        }

        Console.WriteLine("Saludo finalizado.");
    }
}
