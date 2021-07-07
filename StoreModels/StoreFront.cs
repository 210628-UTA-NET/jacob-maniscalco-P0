using System;
using System.Collections.Generic;

namespace StoreModels {
    public class StoreFront 
    {

        private string _name;
        private string _address;
        private List<LineItem> _inventory;
        private List<Order> _orders;
        public StoreFront()
        { }
        public string name 
        { 
            get
            {
                return _name;
            } 
            set
            {
                _name = value;
            }
        }
        public string address 
        { 
            get
            {
                return _address;
            } 
            set
            {
                _address = value;
            } 
        }
        public List<LineItem> inventory 
        { 
            get
            {
                return _inventory;
            } 
            set
            {
                _inventory = value;
            } 
        }
        public List<Order> orders 
        { 
            get
            {
                return _orders;
            } 
            set
            {
                _orders = value;
            } 
        }


        public void displayStoreFrontInfo()
        {
            Console.WriteLine("----StoreFront Info----");
            Console.WriteLine(this.name);
            Console.WriteLine(this.address);
            Console.WriteLine("----Inventory----");
            foreach(LineItem item in this.inventory)
            {
                Console.WriteLine("----Item----");
                Console.WriteLine(item.product.Name);
                Console.WriteLine(item.product.Price);
                Console.WriteLine(item.product.Description);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("----Orders----");
            foreach(Order order in this.orders)
            {
                int counter = 1;
                Console.WriteLine("Order " + counter + " info:");
                Console.WriteLine("Location: " + order.location);
                Console.WriteLine("Price: " + order.price);
                foreach(LineItem item in order.items)
                {        
                    Console.WriteLine("----Item----");
                    Console.WriteLine(item.product.Name);
                    Console.WriteLine(item.product.Price);
                    Console.WriteLine(item.product.Description);
                    Console.WriteLine("-------------");
                }

                counter++;
            }
        }
    }
}