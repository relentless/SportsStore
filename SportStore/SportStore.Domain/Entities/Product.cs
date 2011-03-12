using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;

namespace SportStore.Domain.Entities {
    [Table(Name="Products")]
    public class Product {

        [ScaffoldColumn(false)]
        [Column(IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.OnInsert)]
        public int ProductID { get; set; }

        [Required(ErrorMessage="Please enter name")]
        [Column] 
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Column]
        public string Description { get; set; }

        [Range(0.0, double.MaxValue)]
        [Column]
        public decimal Price { get; set; }

        [Required(ErrorMessage="you must enter a category")]
        [Column]
        public string Category { get; set; }
    }
}
