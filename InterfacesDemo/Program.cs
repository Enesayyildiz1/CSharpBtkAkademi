using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] worker = new IWorker[3]
            {
                new Robot (),
                new Worker (),
                new Manager ()
            };
            foreach (var eleman in worker )
            {
                eleman.Work();
            }
            

            ISalary[] salaries = new ISalary[2]
            {
             
               new Worker (),
               new Manager ()
            };
            foreach (var maaşalan in salaries )
            {
                maaşalan.GetSalary();
            }

Console.Read();
        }
    }
}
