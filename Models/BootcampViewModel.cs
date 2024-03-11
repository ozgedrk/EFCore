using EFCore.Data;
using System.ComponentModel.DataAnnotations;

namespace EFCore.Models
{
    public class BootcampViewModel
    {
        public int KursId { get; set; }
        [Required(ErrorMessage = "Kurs başlığı girmek zorunlu!")]
        [StringLength(70)]
        public string? Baslik { get; set; }
        public int EgitmenId { get; set; }
        public ICollection<BootcampKayit> Kayitlar { get; set; } = new List<BootcampKayit>();
    }
}
