using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace INTEX2v2.Models
{
    public class Recommendation
    {
        [Key]
        [ForeignKey("Product")]
        public int product_ID { get; set; }
        public Product Product { get; set; }
        public int? reccomendation_1 { get; set; }
        public int? reccomendation_2 { get; set; }
        public int? reccomendation_3 { get; set; }
        public int? reccomendation_4 { get; set; }
        public int? reccomendation_5 { get; set; }
    }
}
