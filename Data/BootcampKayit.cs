using System.ComponentModel.DataAnnotations;

namespace EFCore.Data
{
    public class BootcampKayit
    {
        [Key]
        public int KayitId { get; set; }

        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; } = null!;

        public int KursId { get; set; }
        public Bootcamp Kurs { get; set; } = null!;

        public DateTime KayitTarihi { get; set; }

    }
}