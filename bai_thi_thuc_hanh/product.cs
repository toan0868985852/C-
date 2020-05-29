using System;
using System.Collections.Generic;
using System.Text;

namespace bai_thi_thuc_hanh
{
    class product
    {
        public static void Main(string[] args)
        {
            products[] listPr = new products[6];
            listPr[0] = new Book(1, "Dat gioi toan dien", 5000, "Nguyen Huy Toan");
            listPr[1] = new Book(2, "CodeVN", 6000, "Tran van hoang");
            listPr[2] = new Book(3, "CodeLean", 7000, "Dang Kim Thi");
            listPr[3] = new MobilePhone(4, "Oppo f11", 8000, "Nokia");
            listPr[4] = new MobilePhone(5, "Xiaomi mi 10", 9000, "Xiaomi");
            listPr[5] = new MobilePhone(6, "Iphone 11", 10000, "Apple");

           
            double taxBook = 0;
            for (int i = 0; i <= 2; i++)
            {
                taxBook += listPr[i].computeTax();

            }

            double taxMobilePhone = 0;
            for (int i = 3; i <= 5; i++)
            {
                taxMobilePhone += listPr[i].computeTax();

            }

            double computeTotaltax = 0;
            for (int i = 0; i < listPr.Length; i++)
            {
                computeTotaltax += listPr[i].computeTax();
                Console.WriteLine(listPr[i].ToString());
            }

            Console.WriteLine("Compute Total tax of Book: " + taxBook);
            Console.WriteLine("Compute Total tax of MobilePhone: " + taxMobilePhone);
            Console.WriteLine("Compute Total tax : " + computeTotaltax);
        }
    }
}
