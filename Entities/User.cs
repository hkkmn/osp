using System.ComponentModel.DataAnnotations;

namespace osp.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string? FullName { get; set; } = null;
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Locked { get; set; } = false;
        [Required]
        [StringLength(20)]
        public string Role { get; set; } = "user";
    }
}
