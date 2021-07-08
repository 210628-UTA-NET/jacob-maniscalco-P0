using System;

namespace StoreModels
{
    public class OrderItem
    {
        private Product _product;
        private int _quantity;

        public OrderItem()
        {}

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
    }
}