using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourStory.Entities
{
    [Table("Categories")]
    public class Category : EntitityBase
    {
        [Required,StringLength(50)]
        public string Title { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        public List<Story> Storys { get; set; }
        public Category()
        {
            Storys = new List<Story>();
        }
    }
}
