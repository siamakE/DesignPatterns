using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Tests.Builder
{
    [TestClass]
    public class ProductBuilderTest
    {
        [TestMethod]
        public void MainProductCreate()
        {
            var p2 = new Product("C");
            p2.AddPart("partX");
            p2.AddPart("partY");
            p2.ShowParts();

            Director director = new Director();

            IBuilder builderA = new BuilderA();
            director.Construct(builderA);
            Product p3 =  builderA.GetResult();
            p3.ShowParts();

            var builderA2 = new BuilderA();
            builderA2.buildParts();
            var p5 = builderA2.GetResult();
            p5.ShowParts();

            IBuilder builderB = new BuilderB();
            director.Construct(builderB);
            Product p4 = builderB.GetResult();
            p4.ShowParts();
        }
    }

    internal interface IBuilder
    {
        Product GetResult();
        void buildParts();
    }

    internal class BuilderB : IBuilder
    {
        public void buildParts()
        {
            _product.AddPart("partX");
            _product.AddPart("partY");
            _product.AddPart("partZ");
        }

        public Product GetResult()
        {
            return _product;
        }

        private Product _product = new Product("B");
    }

    internal class BuilderA : IBuilder
    {
        public void buildParts()
        {
            _product.AddPart("partA");
            _product.AddPart("partB");
            _product.AddPart("partC");
        }

        public Product GetResult()
        {
            return _product;
        }

        private Product _product = new Product("A");
    }

    internal class Director
    {
        internal void Construct(IBuilder builder)
        {
            builder.buildParts();
        }
    }

    public class Product
    {
        public string Name { get; set; }

        public Product(string name)
        {
            Name = name;
        }

        private List<string> _parts = new List<string>();
        public void AddPart(string part)
        {
            _parts.Add(part);
        }
        public void ShowParts()
        {
            Console.WriteLine($"Product {Name}");
            foreach (var part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }

}
