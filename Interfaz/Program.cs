using Ejercicio_Adapter;

namespace Interfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static string Menu()
        {
            while (true)
            {
                Console.WriteLine("Menuuu" +
                    "\nSelecciona una opcion pli" +
                    "\n1. Selecionar sensor" +
                    "\n2. Salir" +
                    "\n");

                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Menuuu" +
                        "\nSelecciona una opcion pli" +
                        "\n1. Sensor de Presion" +
                        "\n2. Sensor de Temperatura" +
                        "\n");

                        opcion  = Convert.ToInt32(Console.ReadLine());
                        IMedir sensor;
                        sensor = FactorySensor.ObtenerSensor(opcion);
                        sensor.Medir();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        return null;
                        break;

                    default:
                        Console.WriteLine("Ingese una opcion valida por favor");
                        break;
                }
            }
        }
    }
}
