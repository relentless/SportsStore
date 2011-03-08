using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SportStore.Domain.Entities;

namespace SportStore.Domain.Abstract {
    public interface IOrderProcessor {
        void ProcessOrder(Cart cart, DeliveryDetails details);
    }
}
