using System.ComponentModel.DataAnnotations;

namespace EFCore.Data
{
    public class Bootcamp{
        [Key]
        public int KursId {get;set;}
        public string? Baslik {get;set;}
        public ICollection<BootcampKayit> BootcampKayitlari { get; set; } = new List<BootcampKayit>();

    }
}