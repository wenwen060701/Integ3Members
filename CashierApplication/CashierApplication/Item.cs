using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    public class Item
    {
        private string _itemName;
        private double _itemPrice;
        private int _itemQuantity;
        protected double _totalPrice;

        public Item(string name, double price, int quantity)
        {
            _itemName = name;
            _itemPrice = price;
            _itemQuantity = quantity;
            _totalPrice = 0.0;
        }
        public virtual double getTotalPrice()
        {
            return _totalPrice;
        }

        public void setPayment(double amount)
        {
            _totalPrice = amount;
        }
    }

}
