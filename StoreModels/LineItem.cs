namespace StoreModels {
    public class LineItem
    {
        private Product _product;
        private int _quantity;

        public LineItem()
        { }


        public Product Product 
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
        public int Quantity 
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

        public override string ToString()
        {
            return Product.ToString() + 
                    $"Quantity: {Quantity}";
        }
    }
}