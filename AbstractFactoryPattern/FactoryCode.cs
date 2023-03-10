/**
 * @file FactoryCode.cs
 * @author Connor Walsh
 * @date 2023-1-31
 * @brief AbstractFactoryPattern factory class implementation
 * 
 * This file contains the implementation code for and the interface of the IPhoneFactory classes. 
 * It also contains the Manufacturers enumerator and the PhoneTypeChecker class for testing
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface IPhoneFactory
    {
        ISmart GetSmart();
        IDumb GetDumb();
    }

    public class SamsungFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            ISmart phone = new GalaxyS2();
            return phone;
        }

        public IDumb GetDumb()
        {
            IDumb phone = new Primo();
            return phone;
        }

    }

    public class HTCFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            ISmart phone = new Titan();
            return phone;
        }

        public IDumb GetDumb()
        {
            IDumb phone = new Genie();
            return phone;
        }

    }

    public class NokiaFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            ISmart phone = new Lumia();
            return phone;
        }

        public IDumb GetDumb()
        {
            IDumb phone = new Asha();
            return phone;
        }

    }

    public enum Manufacturers
    {
        SAMSUNG,
        HTC,
        NOKIA
    }

    public class PhoneTypeChecker
    {
        IPhoneFactory factory;
        Manufacturers manu;
        public PhoneTypeChecker(Manufacturers m)
        {
            manu = m;
            CheckProducts();
        }

        public void CheckProducts()
        {
            switch (manu)
            {
                case Manufacturers.SAMSUNG:
                    factory = new SamsungFactory();
                    Console.WriteLine("Dumb Phone: " + factory.GetDumb().getName());
                    Console.WriteLine("Smart Phone: " + factory.GetSmart().getName());
                    break;
                case Manufacturers.HTC:
                    factory = new HTCFactory();
                    Console.WriteLine("Dumb Phone: " + factory.GetDumb().getName());
                    Console.WriteLine("Smart Phone: " + factory.GetSmart().getName());
                    break;
                case Manufacturers.NOKIA:
                    factory = new NokiaFactory();
                    Console.WriteLine("Dumb Phone: " + factory.GetDumb().getName());
                    Console.WriteLine("Smart Phone: " + factory.GetSmart().getName());
                    break;
                default:
                    Console.WriteLine("Not a choice");
                    break;
            }
        }
    }
}
