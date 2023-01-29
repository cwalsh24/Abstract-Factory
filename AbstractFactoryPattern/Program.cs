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
            return "stuff"; 
        }
    }

    public class Genie : IDumb
    {
        public string getName()
        {
            return "stuff";
        }
    }

    public class Primo : IDumb
    {
        public string getName()
        {
            return "stuff";
        }
    }
    //IDUMB STUFF ENDS

    //IPHONEFACTORY STUFF
    public interface IPhoneFactory
    {
        //public ISmart GetSmart();
        //public IDumb GetDumb();
    }

    public class SamsungFactory : IPhoneFactory
    {

    }

    public class HTCFactory : IPhoneFactory
    {

    }

    public class NokiaFactory : IPhoneFactory
    {

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
            return "stuff";
        }
    }

    public class GalaxyS2 : ISmart
    {
        public string getName()
        {
            return "stuff";
        }
    }

    public class Titan : ISmart
    {
        public string getName()
        {
            return "stuff";
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

        }

        public void CheckProducts()
        {
            //set internal factory to correct factory then write both phone types to console
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //new phoneTypeChecker and pass in an enum run check products, so for all products
        }
    }
}
