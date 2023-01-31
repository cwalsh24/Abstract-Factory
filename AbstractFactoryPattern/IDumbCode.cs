using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
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
}
