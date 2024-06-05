using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    public class DiscountedItem : Item
    {
        private double _itemDiscount;
        private double _discountedPrice;
        private double _paymentamount;
        private double _itemPrice;
        private int _itemQuantity;
        private double _change;

        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {
            _itemDiscount = discount;
            _discountedPrice = 0.0;
            _paymentamount = 0.0;
            _change = 0.0;
        }

        public override double getTotalPrice()
        {
            calculateDiscountedPrice();
            _totalPrice = _discountedPrice * _itemQuantity;
            return _totalPrice;
        }

        public void setPayment(double amount)
        {
            _paymentamount = amount;
            calculateChange();
        }

        public double getChange()
        {
            return _change;
        }

        private void calculateDiscountedPrice()
        {
            _discountedPrice = _itemPrice * (1 - (_itemDiscount * 0.01));

        }

        private void calculateChange()
        {
            _change = _paymentamount - getTotalPrice();
        }

    }
    }
        