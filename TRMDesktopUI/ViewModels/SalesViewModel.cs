using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRMDesktopUI.Library.Api;
using TRMDesktopUI.Library.Models;

namespace TRMDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        private IProductEndpoint _productEndpoint;

        private BindingList<ProductModel> _products;

        private int _itemQuantity;

        private BindingList<ProductModel> _cart;

        public SalesViewModel(IProductEndpoint productEndpoint)
        {
            _productEndpoint = productEndpoint;


        }

        public BindingList<ProductModel> Products
        {
            get { return _products; }
            set 
            { 
                _products = value;

                NotifyOfPropertyChange(() => Products);
            }
        }

        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set 
            { 
                _itemQuantity = value;

                NotifyOfPropertyChange(() => ItemQuantity);
            }
        }    

        public BindingList<ProductModel> Cart
        {
            get { return _cart; }
            set 
            { 
                _cart = value;

                NotifyOfPropertyChange(() => Cart);
            }
        }

        public string SubTotal
        {
            get
            {
                // TODO - Replace with calculation
                return "$0.00";
            }
        }

        public string Tax
        {
            get
            {
                // TODO - Replace with calculation
                return "$0.00";
            }
        }

        public string Total
        {
            get
            {
                // TODO - Replace with calculation
                return "$0.00";
            }
        }

        public bool CanAddToCart 
        { 
            get
            {
                bool output = false;

                // Make sure something is selected

                // Make sure there is an item quantity

                if (true)
                {

                }

                return output;
            } 
        }

        public void AddToCart()
        {

        }

        public bool CanRemoveFromCart
        {
            get
            {
                bool output = false;

                // Make sure something is selected

                if (true)
                {

                }

                return output;
            }
        }

        public void RemoveFromCart()
        {

        }

        public bool CanCheckOut
        {
            get
            {
                bool output = false;

                // Make sure there is something in the cart

                if (true)
                {

                }

                return output;
            }
        }

        public void CheckOut()
        {

        }
    }
}
