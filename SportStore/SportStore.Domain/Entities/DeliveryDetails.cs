using System;
using System.ComponentModel.DataAnnotations;

namespace SportStore.Domain.Entities {
    public class DeliveryDetails {
        [Required(ErrorMessage="Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Address")]
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        [Required(ErrorMessage = "Enter Postcode")]
        public string Postcode { get; set; }

        public bool GiftWrap { get; set; }
    }
}
