using ConsoleApp.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        var cafetera = new Cafetera(50);
        var vasosPequeno = new Vaso(5, 3);
        var vasosMediano = new Vaso(5, 5);
        var vasosGrande = new Vaso(5, 7);
        var azucarero = new Azucarero(20);

        var maquinaDeCafe = new MaquinaDeCafe(cafetera, vasosPequeno, vasosMediano, vasosGrande, azucarero);

        while (true)
        {
            Console.WriteLine("Seleccione el tipo de vaso:");
            Console.WriteLine("1. Pequeño");
            Console.WriteLine("2. Mediano");
            Console.WriteLine("3. Grande");
            Console.Write("Opción: ");

            if (!int.TryParse(Console.ReadLine(), out int opcionVaso) || opcionVaso < 1 || opcionVaso > 3)
            {
                Console.WriteLine("Opción no válida, intente de nuevo.");
                continue;
            }

            string tipoVaso = opcionVaso switch
            {
                1 => "pequeno",
                2 => "mediano",
                3 => "grande",
                _ => null
            };

            Console.Write("Ingrese la cantidad de vasos: ");
            if (!int.TryParse(Console.ReadLine(), out int cantidadVasos) || cantidadVasos <= 0)
            {
                Console.WriteLine("Cantidad no válida, intente de nuevo.");
                continue;
            }

            Console.Write("Ingrese la cantidad de azúcar (cucharadas): ");
            if (!int.TryParse(Console.ReadLine(), out int cantidadAzucar) || cantidadAzucar < 0)
            {
                Console.WriteLine("Cantidad no válida, intente de nuevo.");
                continue;
            }

            string resultado = maquinaDeCafe.GetVasoDeCafe(tipoVaso, cantidadVasos, cantidadAzucar);
            Console.WriteLine(resultado);

            if (resultado == "Felicitaciones")
            {
                Console.WriteLine($"Café restante: {cafetera.GetCantidadCafe()}ml");
                Console.WriteLine($"Azúcar restante: {azucarero.GetCantidadAzucar()} cucharadas");
                Console.WriteLine($"Vasos restantes: {maquinaDeCafe.GetTipoVaso(tipoVaso).GetCantidadVasos()} del tipo {tipoVaso}");
            }

            Console.WriteLine();
            Console.WriteLine("¿Desea realizar otra operación?");
            Console.WriteLine("1. Sí");
            Console.WriteLine("2. No");
            Console.Write("Opción: ");
            if (!int.TryParse(Console.ReadLine(), out int continuar) || continuar != 1)
            {
                Console.WriteLine("Gracias por usar la máquina de café. ¡Adiós!");
                break;
            }

            Console.Clear();
        }
    }
}
