using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UltimateFunCenter.Model
{
    public class Floor
    {
        [Key]
        public int Id {  get; set; }

        [Required]
        public int Level { get; set; }

        [ForeignKey("Building")]
        public int BuildingId { get; set; }

        public virtual Building Building { get; set; }
    }
}
