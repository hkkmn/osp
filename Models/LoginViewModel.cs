using System.ComponentModel.DataAnnotations;

namespace osp.Models
{
    public class LoginViewModel
    {
        /*zorunluluk ve max uzunluk*/
        [Required(ErrorMessage = "kullanıcı adı zorunludur")]
        [StringLength(25)]
        public string Username { get; set; }
        //htmld de type="password yazmakla aynı
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "şifre zorunludur")]
        [MinLength(6)]
        [MaxLength(10)]
        public string Password { get; set; }
    }
}
