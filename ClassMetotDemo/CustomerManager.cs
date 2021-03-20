using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Sayın" +customer.Ad + " " + customer.Soyad +"Kaydınız başarıyla oluşturuldu. :)" );
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Sayın" +" " + customer.Ad + " " + customer.Soyad+ " "+ "Kaydınız silinmiştir.");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Sayın" + " " + customer.Ad + " " + customer.Soyad + " " + "Bilgileriniz başarıyla güncellenmiştir. :)");
        }
    }
}
