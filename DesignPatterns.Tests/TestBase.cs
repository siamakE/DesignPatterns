using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static DesignPatterns.Tests.AbstractFactoryTests.FurnitureTest;
using DesignPatterns.Tests.BuilderTests;

namespace DesignPatterns.Tests
{
    public class TestBase
    {
        protected IServiceProvider ServiceProvider;

        [TestInitialize]
        public void SetUp()
        {

            ServiceProvider = new ServiceCollection()
                .AddSingleton<IFurnitureFactory, VictoriaFornitureFactory>()
                .AddSingleton<IToyBuilder, ToyBBuilder>()
                .BuildServiceProvider();
        }
    }
}
