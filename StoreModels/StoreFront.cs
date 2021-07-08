using System;
using System.Collections.Generic;

namespace StoreModels {
    public class StoreFront 
    {

        private int _id;
        private string _name;
        private string _address;
        private List<LineItem> _inventory;
        private List<Order> _orders;
        public StoreFront()
        { }

        public int ID 
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
            
        
        public string Name 
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
        public string Address 
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
        public List<LineItem> Inventory 
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
        public List<Order> Orders 
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
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Address);
            Console.WriteLine("----Inventory----");
            foreach(LineItem item in this.Inventory)
            {
                Console.WriteLine("----Item----");
                Console.WriteLine(item.Product.Name);
                Console.WriteLine(item.Product.Price);
                Console.WriteLine(item.Product.Description);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("----Orders----");
            foreach(Order order in this.Orders)
            {
                int counter = 1;
                Console.WriteLine("Order " + counter + " info:");
                Console.WriteLine("Location: " + order.Location);
                Console.WriteLine("Price: " + order.Price);
                foreach(OrderItem item in order.Items)
                {        
                    Console.WriteLine("----Item----");
                    Console.WriteLine(item.Product.Name);
                    Console.WriteLine(item.Product.Price);
                    Console.WriteLine(item.Product.Description);
                    Console.WriteLine("-------------");
                }

                counter++;
            }
        }
    }
}