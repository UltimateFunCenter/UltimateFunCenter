using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UltimateFunCenter.Model
{
    public class Facility
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [ForeignKey("Floor")]
        public int FloorId { get; set; }
        public virtual Floor? Floor { get; set; }
    }
}
