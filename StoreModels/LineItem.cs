namespace StoreModels {
    public class LineItem
    {
        private Product _product;
        private int _quantity;

        public LineItem()
        { }


        public Product product 
        { 
            get
            {
                return _product;
            } 
            set
            {
                _product = value;
            } 
        }
        public int quantity 
        { 
            get
            {
                return _quantity;
            } 
            set
            {
                _quantity = value;
            } 
        }
    }
}