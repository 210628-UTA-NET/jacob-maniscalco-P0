using System.Collections.Generic;

namespace StoreModels {
    public class Customer 
    {

        private string _name;
        private string _address;
        private string _phoneNumber;
        private List<Order> _orders;
        public Customer()
        { }
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
        public string phoneNumber 
        { 
            get
            {
                return _phoneNumber;
            } 
            set
            {
                _phoneNumber = value;
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