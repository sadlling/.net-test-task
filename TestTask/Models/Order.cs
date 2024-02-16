namespace TestTask.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string ProductName { get; set; } = string.Empty!;

        public int Price { get; set; }

        public int Quantity { get; set; } 

        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
