using System;

namespace SportStore.WebUI.Models {
    public class CategoryLink {
        public string Category { get; set; }
        public bool IsSelected { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
    }
}
