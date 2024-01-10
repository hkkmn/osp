using System.ComponentModel.DataAnnotations;

namespace osp.Models
{
    public class RegisterViewModel
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
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "şifre zorunludur")]
        [MinLength(6)]
        [MaxLength(10)]
        //compare şifreyi karşılaştırmak için nameof u kullanma nedeni hata yaparsak görebilmek 
        [Compare(nameof(Password))]
        public string RePassword { get; set; }
    }
}
