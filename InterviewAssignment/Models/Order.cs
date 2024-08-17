using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InterviewAssignment.Models
{
    public class Order
    {
        [Key]
        public int Order_id { get; set; }
        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }
        public ICollection<OrderDetail> orderdetail { get; set; }
    }
}
