using ClassMetotDemo_CSharpTemelleri2Odev;

Customer customer1 = new Customer();
customer1.Id = 0;
customer1.Name = "Gökay";
customer1.SurName = "Baz";

Customer customer2 = new Customer();
customer2.Id = 1;
customer2.Name = "Benan";
customer2.SurName = "Baz";

Customer customer3 = new Customer();
customer3.Id = 2;
customer3.Name = "Hakkı";
customer3.SurName = "Baz";

Customer[] myCustomers = new Customer[] { customer1, customer2, customer3 };

CustomerManager customerManager = new CustomerManager();

customerManager.Add(customer1);
customerManager.Delete(customer2);
customerManager.List(myCustomers);