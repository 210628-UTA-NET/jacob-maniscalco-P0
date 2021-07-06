using System.Collections.Generic;
using System.Text.RegularExpressions;

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
                if(!Regex.IsMatch(value, @"^[A-za-z ,.'-]+$"))
                {
                    throw new System.Exception("Incorrect name format");
                }
                else
                {
                    _name = value;
                }
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
                if(!Regex.IsMatch(value, @"^[\d{1-5}\sA-Za-z0-9\.\-]+$"))
                {
                    throw new System.Exception("Incorrect address format.");
                }
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
                if(!Regex.IsMatch(value, @"^\d{10}$"))
                {
                    throw new System.Exception("Incorrect phone number format.");
                }
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