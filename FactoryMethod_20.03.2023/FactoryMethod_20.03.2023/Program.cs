using FactoryMethod_;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RoadLogistics roadLogistics = new RoadLogistics();
            Transport transport = roadLogistics.CreateObject();
            Logistics.AddTransport(transport);
            SeaLogistics seaLogistics = new SeaLogistics();
            Transport transport2 = seaLogistics.CreateObject();
            Logistics.AddTransport(transport2);
            for (int i = 0; i < Logistics.GetLength(); i++)
            {
                Logistics.GetTransport(i).deliver();
            }
        }
    }
}
