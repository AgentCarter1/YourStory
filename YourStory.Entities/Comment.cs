using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace YourStory.Entities
{
    [Table("Comments")]
    public class Comment : EntitityBase
    {
        [Required,StringLength(300)]
        public string Text { get; set; }
        public Story Story { get; set; }
        public YourStoryUser Owner { get; set; }
    }
}
