using System;

namespace StoreModels
{
    public class OrderItem
    {
        private Product _product;
        private int _quantity;

        public OrderItem()
        {}

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