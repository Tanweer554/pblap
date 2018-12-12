using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();
            obj.Add(10); // Value type to Ref type : Boxing
            obj.Add(1.23);
            obj.Add("Wipro");

            Console.WriteLine(obj[0]);
            Console.WriteLine(obj[1]);
            Console.WriteLine(obj[2]);

            Console.Write("Enter a value:");
            obj.Add(Console.ReadLine());

            Console.WriteLine("Count:" + obj.Count);

            foreach (object item in obj)
                Console.WriteLine(item);

            Console.WriteLine("Using Enumerator");

            IEnumerator e = obj.GetEnumerator();

            while (e.MoveNext())
                Console.WriteLine(e.Current);
        }
    }
}
