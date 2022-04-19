using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesignPatterns.Tests
{
    public class TestBase
    {
        protected IServiceProvider ServiceProvider;

        [TestInitialize]
        public void SetUp()
        {

            ServiceProvider = new ServiceCollection()
                .AddSingleton<ITest, Test>()
                .BuildServiceProvider();
        }
    }
    public interface ITest
    {
        void print();
    }
    public class Test : ITest
    {
        public void print()
        {
            throw new NotImplementedException();
        }
    }
}
