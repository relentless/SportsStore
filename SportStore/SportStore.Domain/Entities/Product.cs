using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;

namespace SportStore.Domain.Entities {
    [Table(Name="Products")]
    public class Product {

        [ScaffoldColumn(false)]
        [Column(IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.OnInsert)]
        public int ProductID { get; set; }

        [Column] 
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Column]
        public string Description { get; set; }

        [Column]
        public decimal Price { get; set; }

        [Column]
        public string Category { get; set; }
    }
}
