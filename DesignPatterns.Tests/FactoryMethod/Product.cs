namespace DesignPatterns.Tests.FactoryMethod
{
    /// <summary>
    /// The 'Product' interface class
    /// </summary>
    public interface IProduct
    {
    }
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class ConcreteProductA : IProduct
    {
    }
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class ConcreteProductB : IProduct
    {
    }
    /// <summary>
    /// The 'Creator' interface class
    /// </summary>
    public interface ICreator
    {
        IProduct FactoryMethod();
    }
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class ConcreteCreatorA : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class ConcreteCreatorB : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}