using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.update();
            
            
            ProductManager productManager = new ProductManager();
            productManager.Add();

            Customer customer = new Customer();
            customer.Country = "Zimbabwe";
            customer.Firstname = "Jason";
            customer.Lastname = "Taylor";
            customer.Id = 1;

            Customer customer2 = new Customer()
            {
                Id = 2,Country ="Bangladeş",Firstname ="Madam",Lastname ="Ciouyn"
            };
            Console.WriteLine(customer2 .Firstname );



            Console.ReadKey();
        }
    }
   
   
}
