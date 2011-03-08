using SportStore.Domain.Abstract;
using SportStore.Domain.Entities;

namespace SportStore.Domain.Concrete {
    public class FakeOrderProcessor: IOrderProcessor {
        public void ProcessOrder(Cart cart, DeliveryDetails details) {
            
        }
    }
}
