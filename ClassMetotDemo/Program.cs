using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.IdentityNumber = 1546237567;
            customer1.Ad = "İlknur";
            customer1.Soyad = "Arslan";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.IdentityNumber = 1647596749;
            customer2.Ad = "Şevval";
            customer2.Soyad = "Can";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer2.IdentityNumber = 9647559689;
            customer2.Ad = "Reyyan";
            customer2.Soyad = "Karataş";


            Customer[] customers = new Customer[] {customer1,customer2,customer3 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.Update(customer3);
           



        }
    }
}
