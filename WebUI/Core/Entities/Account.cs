namespace WebUI.Core.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public double Balance { get; set; }
        public string AccountNumber { get; set; }
        public int UserId { get; set; }


        public User User { get; set; }
    }
}
