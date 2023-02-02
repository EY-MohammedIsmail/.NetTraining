using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample_Feb02
{
    class Automobile
    {
        string model = "BMW";
        string color = "Red";
        string type = "FourWheeler";
        static void Main(string[] args)
        {
            Automobile objectOne = new Automobile();
            Console.WriteLine("Model : " + objectOne.model + "\nColor : " + objectOne.color + "\nType : " + objectOne.type);
        }
    }
}
