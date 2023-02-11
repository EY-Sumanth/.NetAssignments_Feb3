using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1_Feb3
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            //string s1 = "Hello Mike C#";
            //string s2 = s1.ToLower();
            //Console.WriteLine(s2);

            string s1 = " Hello";
            string s2 = " hello";
            String s3 = "Boom";
            Console.WriteLine(s1.Substring(2,3));
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s3.Concat(s2));
            Console.WriteLine(s1.Split());
            Console.WriteLine(s2.Split());
            Console.WriteLine(s1.ToLower());
            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s2.Replace(s1,s2));
            Console.WriteLine(s2.Trim());
            Console.WriteLine(s2.IndexOf('l'));
            Console.WriteLine(s2.LastIndexOf('e'));
            Console.WriteLine(s2.Equals(s1));
            Console.WriteLine(s1.Split());


        }
    }
}
