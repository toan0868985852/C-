using System;
using System.Collections.Generic;
using System.Text;

namespace bai_thi_thuc_hanh
{

    public class Book : products
    {
        public Book(int products_id, string name, double price, string producer) : base(products_id, name, price, producer)
        {

        }

        public override double computeTax()
        {
            return price * 8 / 100;
        }

        public override string ToString()
        {
            return "id: " + this.products_id + ", name: " + this.name + ", price: " + this.price + ", producer:  " + this.producer;
        }

    }
}
    
