using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesignPatterns.Tests.Prototype
{
    [TestClass]
    public class PrototypeTests : TestBase
    {
        [TestMethod]
        public void ProductFactoryTest()
        {
            Person p1 = new Person();
            p1.Age = 42;
            p1.BirthDate = Convert.ToDateTime("1977-01-01");
            p1.Name = "Jack Daniels";
            p1.IdInfo = new IdInfo(666);

            var p2 = p1.ShallowCopy();
            var p3 = p1.DeepCopy();
        }
    }
    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            IdNumber = idNumber;
        }
    }
    public class Person
    {
        public Person ShallowCopy()
        {
            return (Person)MemberwiseClone();
        }
        public Person DeepCopy()
        {
            var clone = (Person)MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = String.Copy(Name);
            
            return clone;
        }

        public int Age { get; internal set; }
        public DateTime BirthDate { get; internal set; }
        public string Name { get; internal set; }
        public IdInfo IdInfo { get; internal set; }
    }
}
