using System.ComponentModel.DataAnnotations;
namespace INTEX2v2.Models
{
    public class TwoFactor
    {
        [Required]
        public string TwoFactorCode { get; set; }
    }
}
