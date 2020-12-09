using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context db = new Context())
            {

                Customer person = new Customer { Name = "AlexUnic" };
                Customer person2 = new Customer { Name = "AlexUnic_2" };

                person.Orders.Add(new Order { ProductName = "stol"  });
                person.Orders.Add(new Order { ProductName = "styl" });

                person2.Orders.Add(new Order { ProductName = "stol2" });
                person2.Orders.Add(new Order { ProductName = "styl2" });

                db.Customers.Add(person);
                db.Customers.Add(person2);


                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");


            }
        }
    }
}
