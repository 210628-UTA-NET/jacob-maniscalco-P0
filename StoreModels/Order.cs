using System.Collections.Generic;

namespace StoreModels {
    public class Order {

        private List<LineItems> _order;
        private string _location;
        private double _price;

        public Order()
        { }

        public List<LineItems> order 
        {  
            get
            {
                return _order;
            } 
            set
            {
                _order = value;
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