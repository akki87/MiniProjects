namespace Bank_Project.Model
{
    public class Login
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
