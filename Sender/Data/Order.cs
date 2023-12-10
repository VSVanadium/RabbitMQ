using Sender.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sender.Data
{
    [Table("Order")]
    public class Order : BaseEntity
    {
        public string? ProductName { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
