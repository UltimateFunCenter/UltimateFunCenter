using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UltimateFunCenter.Model
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public  int Age { get; set; }

        [Required]
        public int HowManyPeople { get; set; }

        [Required]
        public int HowMayMinors {  get; set; }

        [ForeignKey("User")]
        public string UserId {  get; set; }
        public virtual IdentityUser User { get; set; }

        [ForeignKey("Facility")]
        public int FacilityId { get; set; }
        public virtual Facility Facility { get; set; }

    }
}
