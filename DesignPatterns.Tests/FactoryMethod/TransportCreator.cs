namespace DesignPatterns.Tests.FactoryMethod
{
    public interface ILogisticCreator
    {
        ITransport CreateTransport();
    }
    public interface ITransport
    {

    }
    public class ShipLogistics : ILogisticCreator
    {
        public ITransport CreateTransport()
        {
            return new Ship();
        }
    }

    internal class RoadLogistics : ILogisticCreator
    {
        public ITransport CreateTransport()
        {
            return new Truck();
        }
    }
    public class Truck : ITransport
    {
    }
    public class Ship : ITransport
    {
    }
}
