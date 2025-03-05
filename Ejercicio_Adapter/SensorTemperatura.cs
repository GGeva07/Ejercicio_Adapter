namespace Ejercicio_Adapter
{
    public class SensorTemperatura : IMedir
    {
        public void Medir()
        {
            Console.WriteLine($"La temperatura se encuentra en 35.20 grados C");
        }
    }
}
