using System;
using Customer;
using Order;

namespace Customer
{
    class Customer_name
    {
        public string nameCustomer;

        public void getName()
        {
            Console.WriteLine("Nhap ten : ");
            nameCustomer = Console.ReadLine();
        }
    }
}

namespace Order
{
    class hang_tap_hoa
    {
        public void Order_hang_tap_hoa()
        {
            Customer_name c1 = new Customer_name();
            c1.getName();
            Console.Write("{0} ", c1.nameCustomer);
            Console.WriteLine("ban da mua san pham tap hoa");
        }
    }
    class hang_banh_keo
    {
        public void Order_hang_banh_keo()
        {
            Customer_name c2 = new Customer_name();
            c2.getName();
            Console.Write("{0} ", c2.nameCustomer);
            Console.WriteLine("ban da mua san pham banh_keo");
        }
    }
}

