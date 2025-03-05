using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Adapter
{
    public class FactorySensor
    {
        public static IMedir ObtenerSensor(int opcion)
        {
            switch (opcion) 
            {
                case 1:
                    return new AdaptadorSensorPresion();
                case 2:
                    return new SensorTemperatura();

                default:
                    Console.WriteLine("Opcion invalida, intenta de nuevo pli");
                    return null;
            }

        }
    }
}
