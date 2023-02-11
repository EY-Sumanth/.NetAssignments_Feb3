using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOL__Feb3
{
    using System;

    class ADD
    {

        int x, y;
        double f;
        string s;

        
        public ADD(int a, double b)
        {
            x = a;
            f = b;
        }

        
        public ADD(int a, string b)
        {
            y = a;
            s = b;
        }

        
        public void show()
        {
            Console.WriteLine("1st constructor (int + float): {0} ",
                                                           (x + f));
        }

        
        public void show1()
        {
            Console.WriteLine("2nd constructor (int + string): {0}",
                                                           (s + y));
        }
    }

    
    class GFG
    {

       
        static void Main()
        {

            
            ADD g = new ADD(10, 20.2);

            
            g.show();


            
            ADD q = new ADD(10, "Roll No. is ");

            
            q.show1();
        }
    }
}
