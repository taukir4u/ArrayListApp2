using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList newList = new ArrayList();

            //Console.WriteLine("Size of ArrayList: " + newList.Count);

            //Console.WriteLine("Trying to add values... ");

            newList.Add(516);
            newList.Add("Taukir");
            newList.Add(176352.276278);

            foreach (var values in newList)
            //foreach (object values in newList)
            {
                Console.WriteLine(values);
            }

            Console.ReadKey();
        }
    }
}
