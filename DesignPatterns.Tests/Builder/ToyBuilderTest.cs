using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DesignPatterns.Tests.Builder
{
    [TestClass]
    public class BuilderTest : TestBase
    {
        [TestMethod]
        public void BuilderTestCases()
        {
            var toyBuilder = ServiceProvider.GetRequiredService<IToyBuilder>();
            var toy = toyBuilder.GetToy();
            toyBuilder.SetModel();
            Console.WriteLine(toy.Model);
            var toyCreator = new ToyCreator(toyBuilder);
            toyCreator.CreateToy();
            var toy2 = toyCreator.GetToy();
        }
    }

}
