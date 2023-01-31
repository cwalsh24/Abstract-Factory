using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
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
