using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InterviewAssignment.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetail_id { get; set; }
        public int Order_id { get; set; }
        [Required]
        [DisplayName("Fruit Name")]
        public string FruitName { get; set; }
        public Order Order { get; set; }
    }
}
