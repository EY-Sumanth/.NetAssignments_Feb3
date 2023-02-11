using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor__Feb3
{
    class Car
    {
        public string model;


        public Car()
        {
            model = "Mustang";
        }

        static void Main(string[] args)
        {
            Car Ford = new Car();
            Console.WriteLine(Ford.model);
        }
    }
}
