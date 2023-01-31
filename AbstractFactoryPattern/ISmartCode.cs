using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
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
}
