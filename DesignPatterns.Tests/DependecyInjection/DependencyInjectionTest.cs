using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesignPatterns.Tests.DependecyInjection
{
    [TestClass]
    public class DependencyInjectionTest : TestBase
    {
        [TestMethod]
        public void IsInjected()
        {
            var ConvertMethod = ServiceProvider.GetRequiredService<Func<string, ITest>>();

            
        }
    }
}
