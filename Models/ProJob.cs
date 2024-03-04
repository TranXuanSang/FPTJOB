using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web16702401.Models
{
    public class ProJob
    {
        [Key]
        public int Id { get; set; }

        public DateTime RegDate { get; set; }

        public int ProfileId { get; set; }
        [ForeignKey("ProfileId")]
        public virtual Profile? ObjProfile { get; set; }

        public int JobId { get; set; }
        [ForeignKey("JobId")]
        public virtual Job? ObjJob { get; set; }








        

    }
}
