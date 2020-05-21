using Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oder
{
    class testOrder
    {
        public static void Main()
        {
            string lua_chon;

            Console.WriteLine("chon san pham: ");
            Console.WriteLine("1-hang tap hoa ");
            Console.WriteLine("2-hang banh keo ");

            lua_chon = Console.ReadLine();
            if(lua_chon == "1")
            {
                hang_tap_hoa h1 = new hang_tap_hoa();
                h1.Order_hang_tap_hoa();
            }
            else
            {
                if(lua_chon == "2")
                {
                    hang_banh_keo h2 = new hang_banh_keo();
                    h2.Order_hang_banh_keo();
                }
                else
                {
                    Console.WriteLine("Chon mat hang: 1 hoac 2");
                }
            }
        }
    }
}
