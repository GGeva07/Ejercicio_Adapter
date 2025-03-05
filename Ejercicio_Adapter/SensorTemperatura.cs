namespace Ejercicio_Adapter
{
    public class SensorTemperatura : IMedir
    {
        public void Medir()
        {
            double temperatura = 35.20;
            Console.WriteLine($"La temperatura se encuentra en {temperatura} grados C");
        }
    }
}
