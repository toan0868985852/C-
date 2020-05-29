using System;


namespace bai_thi_thuc_hanh
{
    public abstract class products
    {
        protected int products_id;
        protected string name;
        protected double price;
        protected string producer;

        public products()
        {
      
        }

        public products(int products_id, string name, double price, string producer)
        {
            this.products_id = products_id;
            this.name = name;
            this.price = price;
            this.producer = producer;
        }

        public abstract double computeTax();

    }

        public class MobilePhone : products
        {
            public MobilePhone(int products_id, string name, double price, string producer) : base(products_id, name, price, producer)
            {

            }

            public override double computeTax()
            {
                return price * 10 / 100;
            }

        public override string ToString()
        {
            return "id: " + this.products_id + ", name: " + this.name + ", price: " + this.price + ", producer:  " + this.producer;
        }
    }

    }
