using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportStore.Domain.Entities {
    public class Cart {
        private List<CartLine> _lines = new List<CartLine>();
        public IList<CartLine> Lines { get { return _lines; } }

        public void  Add( Product product, int quantity ){
            _lines.Add(new CartLine { Product = product, Quantity = quantity });
        }

        public void Clear() {
            _lines.Clear();
        }
    }

    public class CartLine {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
