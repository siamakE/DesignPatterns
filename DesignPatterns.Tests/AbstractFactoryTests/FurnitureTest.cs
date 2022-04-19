using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Extensions.DependencyInjection;
using static DesignPatterns.Tests.AbstractFactoryTests.FurnitureTest;

namespace DesignPatterns.Tests.AbstractFactoryTests
{
    [TestClass]
    public class FurnitureTest : TestBase
    {
        [TestMethod]
        public void TestCases()
        {
            var furnitureFactory = ServiceProvider.GetRequiredService<IFurnitureFactory>();
            FurnitureClient furnitureClient = new FurnitureClient(furnitureFactory);
        }
        public interface IFurnitureFactory
        {
            Chair CreateChair();
            CofeeTable CreateCofeeTable();
            Sofa CreateSofa();
        }
        public class VictoriaFornitureFactory : IFurnitureFactory
        {
            public Chair CreateChair()
            {
                throw new NotImplementedException();
            }

            public CofeeTable CreateCofeeTable()
            {
                throw new NotImplementedException();
            }

            public Sofa CreateSofa()
            {
                throw new NotImplementedException();
            }
        }
        public class ModernFornitureFactory : IFurnitureFactory
        {
            public Chair CreateChair()
            {
                throw new NotImplementedException();
            }

            public CofeeTable CreateCofeeTable()
            {
                throw new NotImplementedException();
            }

            public Sofa CreateSofa()
            {
                throw new NotImplementedException();
            }
        }

    }

    internal class FurnitureClient
    {
        public CofeeTable cofeeTable;
        public Sofa sofa;
        public Chair chair;

        public FurnitureClient(IFurnitureFactory furnitureFactory)
        {
            cofeeTable = furnitureFactory.CreateCofeeTable();
            sofa = furnitureFactory.CreateSofa();
            chair = furnitureFactory.CreateChair();
        }
    }

    public class Sofa
    {
    }

    public class CofeeTable
    {
    }

    public class Chair
    {
    }
}
