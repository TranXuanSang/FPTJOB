using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web16702401.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Status { get; set; }

        [InverseProperty("ObjCategory")]
        public virtual ICollection<Job>? Jobs { get; set; }



    }
}
