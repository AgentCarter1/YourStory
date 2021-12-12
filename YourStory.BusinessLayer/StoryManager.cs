using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourStory.DataAccessLayer.EntityFramework;
using YourStory.Entities;

namespace YourStory.BusinessLayer
{
    public class StoryManager
    {
        private Repository<Story> repo_story = new Repository<Story>();
        public List<Story> GetAllNote()
        {
            return repo_story.List();
        }
    }
}
