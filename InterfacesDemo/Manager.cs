using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            Console.WriteLine("Yönetici maaşını aldı.");
        }

        public void Work()
        {
            Console.WriteLine("Working manager");
        }
    }
}
