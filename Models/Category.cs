using System.ComponentModel.DataAnnotations;

namespace FPTJOB.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Job>? Jobs { get;}
    }
}
