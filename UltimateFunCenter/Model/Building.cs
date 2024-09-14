using System.ComponentModel.DataAnnotations;

namespace UltimateFunCenter.Model
{
    public class Building
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


    }
}
