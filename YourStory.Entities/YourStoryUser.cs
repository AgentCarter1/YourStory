using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace YourStory.Entities
{
    [Table("YourStoryUsers")]
    public class YourStoryUser : EntitityBase
    {
        [StringLength(40)]
        public string Name { get; set; }
        [StringLength(40)]
        public string Surname { get; set; }
        [Required,StringLength(40)]
        public string Username { get; set; }
        [Required, StringLength(90)]
        public string Email { get; set; }
        [Required, StringLength(30)]
        public string Password { get; set; }
        [Required]
        public Guid ActivateGuid { get; set; }
        public bool IsActive { get; set; }     
        public bool IsAdmin { get; set; }
        public List<Story> Storys { get; set; }
        public List<Comment> Comments { get; set; }
        public virtual List<Liked> Likes { get; set; }
        public virtual List<Stars> Stars { get; set; }
    }
}
