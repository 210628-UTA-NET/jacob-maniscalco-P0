using System.Collections.Generic;

namespace StoreModels {
    public class StoreFront 
    {

        private string _name;
        private string _address;
        private List<LineItems> _inventory;
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
        public List<LineItems> inventory 
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
    }
}