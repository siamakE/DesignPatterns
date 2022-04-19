using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesignPatterns.Tests.AbstractFactoryTests
{
    [TestClass]
    public class MobilePhoneTest : TestBase
    {
        [TestMethod]
        public void TestCases()
        {
            IMobilePhone nokiaMobilePhone = new Nokia();
            MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);

            Console.WriteLine("********* NOKIA **********");
            Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
            Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());

            IMobilePhone samsungMobilePhone = new Samsung();
            MobileClient samsungClient = new MobileClient(samsungMobilePhone);

            Console.WriteLine("******* SAMSUNG **********");
            Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
            Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());

        }
        /// <summary>  
        /// The 'AbstractFactory' interface.  
        /// </summary>  
        interface IMobilePhone
        {
            ISmartPhone GetSmartPhone();
            INormalPhone GetNormalPhone();
        }
        /// <summary>  
        /// The 'ConcreteFactory1' class.  
        /// </summary>  
        class Nokia : IMobilePhone
        {
            public ISmartPhone GetSmartPhone()
            {
                return new NokiaPixel();
            }

            public INormalPhone GetNormalPhone()
            {
                return new Nokia1600();
            }
        }
        class Samsung : IMobilePhone
        {
            public ISmartPhone GetSmartPhone()
            {
                return new SamsungGalaxy();
            }

            public INormalPhone GetNormalPhone()
            {
                return new SamsungGuru();
            }
        }
        interface ISmartPhone
        {
            string GetModelDetails();
        }
        /// <summary>  
        /// The 'AbstractProductB' interface  
        /// </summary>  
        interface INormalPhone
        {
            string GetModelDetails();
        }
        /// <summary>  
        /// The 'ProductA1' class  
        /// </summary>  
        class NokiaPixel : ISmartPhone
        {
            public string GetModelDetails()
            {
                return "Model: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
            }
        }
        /// <summary>  
        /// The 'ProductA2' class  
        /// </summary>  
        class SamsungGalaxy : ISmartPhone
        {
            public string GetModelDetails()
            {
                return "Model: Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
            }
        }
        /// <summary>  
        /// The 'ProductB1' class  
        /// </summary>  
        class Nokia1600 : INormalPhone
        {
            public string GetModelDetails()
            {
                return "Model: Nokia 1600\nRAM: NA\nCamera: NA\n";
            }
        }
        /// <summary>  
        /// The 'ProductB2' class  
        /// </summary>  
        class SamsungGuru : INormalPhone
        {
            public string GetModelDetails()
            {
                return "Model: Samsung Guru\nRAM: NA\nCamera: NA\n";
            }
        }
        /// <summary>  
        /// The 'Client' class  
        /// </summary>  
        class MobileClient
        {
            ISmartPhone smartPhone;
            INormalPhone normalPhone;

            public MobileClient(IMobilePhone factory)
            {
                smartPhone = factory.GetSmartPhone();
                normalPhone = factory.GetNormalPhone();
            }

            public string GetSmartPhoneModelDetails()
            {
                return smartPhone.GetModelDetails();
            }

            public string GetNormalPhoneModelDetails()
            {
                return normalPhone.GetModelDetails();
            }
        }
    }

}
