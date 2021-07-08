using System.Collections.Generic;

namespace StoreModels {
    public class Order 
    {
        private List<OrderItem> _items;
        private string _location;
        private double _price;
        public List<OrderItem> items 
        {  
            get
            {
                return _items;
            } 
            set
            {
                _items = value;
            } 
        }
        public string location 
        { 
            get
            {
                return _location;
            }  
            set
            {
                _location = value;
            } 
        }
        public double price 
        { 
            get
            {
                return _price;
            }  
            set
            {
                _price = value;
            } 
        }
    }
}