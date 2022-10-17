namespace MakeCake.DAL
{
    public class Cake
    {
        public int Id { get; set; }
        public int Tiers { get; set; } 
        public int ClientId { get; set; }
        public DateTime DeadLine { get; set; }
        public double Price { get; set; }
        public string? Photo { get; set; }
        public string? Review { get; set; }
        public bool IsDead { get; set; }
    }
}