namespace Ejercicio_Adapter
{
    public class AdaptadorSensorPresion : IMedir
    {
        static SensorPresion Sensor = new();

        public void Medir()
        {
            Console.WriteLine($"La presion es {Sensor.Medir()}");
        }
    }
}
