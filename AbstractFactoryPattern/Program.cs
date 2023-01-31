using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    //IDUMB STUFF
    public interface IDumb
    {
        string getName(); 
    }

    public class Asha : IDumb
    {
        public string getName()
        {
            return "Asha"; 
        }
    }

    public class Genie : IDumb
    {
        public string getName()
        {
            return "Genie";
        }
    }

    public class Primo : IDumb
    {
        public string getName()
        {
            return "Primo";
        }
    }
    //IDUMB STUFF ENDS

    //IPHONEFACTORY STUFF
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
    //IPHONEFACTORY STUFF ENDS

    //ISMART begins
    public interface ISmart
    {
        string getName();
    }

    public class Lumia : ISmart
    {
        public string getName()
        {
            return "Lumia";
        }
    }

    public class GalaxyS2 : ISmart
    {
        public string getName()
        {
            return "GalaxyS2";
        }
    }

    public class Titan : ISmart
    {
        public string getName()
        {
            return "Titan";
        }
    }

    //ISMART STUFF ENDS

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
            //set internal factory to correct factory then write both phone types to console
            switch (manu)
            {
                case Manufacturers.SAMSUNG:
                    factory = new SamsungFactory();
                    string dumb = factory.GetDumb().getName();
                    string smart = factory.GetSmart().getName();
                    Console.WriteLine(dumb);
                    Console.WriteLine(smart);
                    break;
                case Manufacturers.HTC:
                    factory = new HTCFactory();
                    string dumb1 = factory.GetDumb().getName();
                    string smart1 = factory.GetSmart().getName();
                    Console.WriteLine(dumb1);
                    Console.WriteLine(smart1);
                    break;
                case Manufacturers.NOKIA:
                    factory = new NokiaFactory();
                    string dumb2 = factory.GetDumb().getName();
                    string smart2 = factory.GetSmart().getName();
                    Console.WriteLine(dumb2);
                    Console.WriteLine(smart2);
                    break;
                default:
                    Console.WriteLine("Not a choice");
                    break;
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //new phoneTypeChecker and pass in an enum run check products, so for all products
            PhoneTypeChecker check;

            foreach (Manufacturers manu in Enum.GetValues(typeof(Manufacturers)))
            {
                Console.WriteLine(manu + " Factory");
                check = new PhoneTypeChecker(manu);
                Console.WriteLine(); 
            }
            Console.ReadKey();
        }
    }
}
