using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcParts
{
    class product
    {
        /*        
        public string Name { get; internal set; }
        public object Id { get; internal set; }
        public string Description { get; internal set; }
        public object Quantity { get; internal set; }
        public double Price { get; internal set; }
        */
        public string name;

        public int id;

        public string description;

        public int quantity;

        public double price;

        public product(string name, int id, string description, int quantity, double price)
        {
            this.name = name;
            this.id = id;
            this.description = description;
            this.quantity = quantity;
            this.price = price;
        }
        public product()
        {

        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {

                this.name = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {

                this.id = value;

            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.description = value;
            }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }

            set
            {

                this.quantity = value;

            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.price = value;
            }
        }

        public void applyDiscount(double discount)
        {
            this.price = this.price * (1 - (discount / 100));
        }
    }


}

