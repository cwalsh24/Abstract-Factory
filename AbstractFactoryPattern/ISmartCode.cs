/**
 * @file ISmartCode.cs
 * @author Connor Walsh
 * @date 2023-1-31
 * @brief AbstractFactoryPattern ISmart implementation
 * 
 * This file contains the implementation code for the interface and ISmart phone classes. 
 */

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
