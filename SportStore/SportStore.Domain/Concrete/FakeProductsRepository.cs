using System;
using System.Collections.Generic;
using System.Linq;
using SportStore.Domain.Abstract;
using SportStore.Domain.Entities;

namespace SportStore.Domain.Concrete {
    public class FakeProductsRepository: IProductsRepository {

        private static IQueryable<Product> _products = (new List<Product> {
            new Product { Name="Golf Clubs", Price = 99.99m},
            new Product { Name="Boxing Gloves", Price = 20},
            new Product { Name="Trainers", Price = 49.50m},
        }).AsQueryable();

        public IQueryable<Product> Products {
            get { return _products; }
        }

        public void Save(Product product) {
            throw new NotImplementedException();
        }


        public void Delete(Product product) {
            throw new NotImplementedException();
        }
    }
}
