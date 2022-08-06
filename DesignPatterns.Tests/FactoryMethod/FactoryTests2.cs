using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DesignPatterns.Tests.FactoryMethod
{
    [TestClass]
    public class FactoryTests2
    {
        [TestMethod]
        public void ProductFactoryTest()
        {
            ICreator2 creator2 = new Creator2();
            var p = creator2.FactoryMethod();
            Console.WriteLine(p.GetType().Name);
        }

    }
    public interface IProduct2
    {

    }
    public class Product2 : IProduct2
    {

    }
    public interface ICreator2
    {
        IProduct2 FactoryMethod();
    }
    public class Creator2 : ICreator2
    {
        public IProduct2 FactoryMethod()
        {
            return new Product2();
        }
    }


}
