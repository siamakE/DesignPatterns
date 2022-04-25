using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Tests.FactoryMethod
{
    [TestClass]
    public class FactoryTests : TestBase
    {
        [TestMethod]
        public void ProductFactoryTest()
        {
            var creator = ServiceProvider.GetRequiredService<ICreator>();
            
            var product = creator.FactoryMethod();
            Assert.IsNotNull(product);
            Assert.IsInstanceOfType(product, typeof(ConcreteProductB));
        }
        [TestMethod]
        public void LogisticFactoryTest()
        {
            var creator = ServiceProvider.GetRequiredService<ILogisticCreator>();

            var transport = creator.CreateTransport();
            Assert.IsNotNull(transport);
            Assert.IsInstanceOfType(transport, typeof(Ship));
        }
    }


}
