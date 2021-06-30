namespace StoreModels { 
    public class Product
    {

        private string _name;
        private double _price;
        private string _description;
        private string _category;
        public Product()
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
        public string description 
        { 
            get
            {
                return _description;
            } 
            set
            {
                _description = value;
            } 
        }
        public string category 
        { 
            get
            {
                return _category;
            } 
            set
            {
                _category = value;
            } 
        }
    }
}