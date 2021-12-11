using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace YourStory.Entities
{
    [Table("Stars")]
    public class Stars
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual Story Story { get; set; }
        public virtual YourStoryUser StarsUser { get; set; }
    }
}
