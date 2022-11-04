namespace Tryitter.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string? Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public ICollection<Post>? Posts { get; }
    }
}