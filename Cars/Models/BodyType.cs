using System.ComponentModel.DataAnnotations;

namespace Cars.Models
{
    public class BodyType
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Body Type Bos Ola Bilmez")]
        [MaxLength(25, ErrorMessage = "Body Type 25 Herfden Boyuk Ola Bilmez")]
        [MinLength(3, ErrorMessage = "Body Type 3 Herfden Kicik Ola Bilmez")]
        public string Body { get; set; }
      public  List<Vehicles> Vehicles { get; set; }
    }
}
