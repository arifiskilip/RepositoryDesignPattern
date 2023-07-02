using System.ComponentModel.DataAnnotations;

namespace WebUI.Entities.Models
{
    public class CreateAccountModel
    {
        [Required(ErrorMessage ="Bakiye girilmesi zorunludur.")]
        [Range(0,1000,ErrorMessage ="Aralık 0 ila 1000 arasında olmalıdır.")]
        public double Balance { get; set; }
        [Required(ErrorMessage ="Hesap Numarasını giriniz.")]
        [MinLength(3,ErrorMessage ="Geçerli bir hesap numrası giriniz.")]
        public string AccountNumber { get; set; }
        public int UserId { get; set; }
    }
}
