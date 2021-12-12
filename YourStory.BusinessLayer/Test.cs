using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourStory.Entities;

namespace YourStory.BusinessLayer
{
    public class Test
    {
        private Repository<YourStoryUser> repo_user = new Repository<YourStoryUser>();
        private Repository<Category> repo_category = new Repository<Category>();
        private Repository<Comment> repo_comment = new Repository<Comment>();
        private Repository<Liked> repo_liked = new Repository<Liked>();
        private Repository<Stars> repo_star = new Repository<Stars>();
        private Repository<Story> repo_story = new Repository<Story>();
        public Test()
        {
            
        }
        public void Insert()
        {
            
            int resuly = repo_user.Insert(new YourStoryUser()
            {
                Name = "asdsa",
                Surname = "sadsa",
                Email = "musadsadsadu.tr",
                IsActive = true,
                IsAdmin = true,
                Username = "burasdsaiin",
                Password = "12asdsadsa56",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now.AddMinutes(5),
                ModifiedUsername = "bursadsadsain1",
            });
        }
        public void Update()
        {

            YourStoryUser user = repo_user.Find(x => x.Username == "burasdsaiin");
            if (user != null)
            {
                user.Username = "ada";

                int result = repo_user.update(user);
            }
        }
        public void Delete()
        {
            YourStoryUser user = repo_user.Find(x => x.Username == "ada");
            if (user != null)
            {
                repo_user.Delete(user);
            }
        }

        public void CommentTest()
        {
            YourStoryUser user = repo_user.Find(x => x.Id == 1);
            Story story = repo_story.Find(x => x.Id == 3);

            Comment comment = new Comment()
            {
                Text = "xzcvzxv",
                Story = story,
                Owner = user,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedUsername = "qweqw",
            };
            repo_comment.Insert(comment);
        }
    }
}
