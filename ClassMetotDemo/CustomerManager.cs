using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo_CSharpTemelleri2Odev
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.SurName + " adlı kullanıcı sisteme eklenmiştir !");
        }

        public void List(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name + " " + customer.SurName);
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id + " numaralı müşteri sistemden silinmiştir !");
        }
    }
}
