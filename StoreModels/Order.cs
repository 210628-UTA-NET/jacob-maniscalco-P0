using System.Collections.Generic;

namespace StoreModels {
    public class Order 
    {
        private int _id;
        private List<OrderItem> _items;
        private string _location;
        private double _price;

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
        public List<OrderItem> Items 
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
        public string Location 
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
        public double Price 
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

        public override string ToString()
        {
            string output = $"\n\n----Customer Order----\n" + 
                            $"|ID: {ID}\n" + 
                            $"|Location: {Location}\n" + 
                            $"|Price: {Price}\n" +
                            $"----------------------\n";
            
            foreach(OrderItem item in Items)
            {
                output += item.ToString();
            }
                            
            return output;
        }
    }
}