using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Worker : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaşını aldı işci");
        }

        public void Work()
        {
            Console.WriteLine("Working worker");
        }
    }
}
