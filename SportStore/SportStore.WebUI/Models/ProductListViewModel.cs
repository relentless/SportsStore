using System;
using System.Collections.Generic;
using SportStore.Domain.Entities;

namespace SportStore.WebUI.Models {
    public class ProductListViewModel {
        public PagingInfo Paging { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
