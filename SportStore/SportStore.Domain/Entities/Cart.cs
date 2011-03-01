using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportStore.Domain.Entities {
    public class Cart {
        private List<CartLine> _lines = new List<CartLine>();
        public IList<CartLine> Lines { get { return _lines; } }

        public void  Add( Product product, int quantity ){

            if (_lines.Count(x=>x.Product.ProductID == product.ProductID) > 0) {
                _lines.Where(x=>x.Product.ProductID == product.ProductID).First().Quantity += quantity;
            }
            else {
                _lines.Add(new CartLine { Product = product, Quantity = quantity });
            }
        }

        public void Remove(int productId) {

            _lines.RemoveAll(x => x.Product.ProductID == productId);
        }

        public void Clear() {
            _lines.Clear();
        }

        public decimal TotalCost {
            get {
                return _lines.Select(x => x.TotalPrice).Sum();
            }
        }
    }

    public class CartLine {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal TotalPrice {
            get { return Product.Price * Quantity; }
        }
    }
}
