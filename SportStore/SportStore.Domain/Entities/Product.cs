using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SportStore.Domain.Entities {
    [Table(Name="Products")]
    public class Product {

        [Column(IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.OnInsert)]
        public int ProductID { get; set; }

        [Column] 
        public string Name { get; set; }

        [Column]
        public string Description { get; set; }

        [Column]
        public decimal Price { get; set; }

        [Column]
        public string Category { get; set; }
    }
}
