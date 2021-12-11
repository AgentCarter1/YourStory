using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using YourStory.Entities;
namespace YourStory.DataAccessLayer
{
    public class MyInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {

            YourStoryUser admin = new YourStoryUser()
            {
                Name = "Burak",
                Surname = "Aydin",
                Email = "mustafa.aydin21@ogr.sakarya.edu.tr",
                IsActive = true,
                IsAdmin = true,
                Username = "burakaydiin",
                Password = "123456",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now.AddMinutes(5),
                ModifiedUsername = "burakaydiin1",
            };
            YourStoryUser standartUser = new YourStoryUser()
            {
                Name = "Bunyamin",
                Surname = "Aydin",
                Email = "bunyamin.aydin3@ogr.sakarya.edu.tr",
                IsActive = true,
                IsAdmin = false,
                Username = "bunyaminaydiin",
                Password = "123456",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now.AddMinutes(65),
                ModifiedUsername = "bunyaminaydiin1",
            };
            context.YourStoryUsers.Add(admin);
            context.YourStoryUsers.Add(standartUser);

            for(int i = 0; i < 8; i++)
            {
                YourStoryUser user = new YourStoryUser()
                {
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Email = FakeData.NetworkData.GetEmail(),
                    IsActive = true,
                    IsAdmin = false,
                    Username = $"user{i}",
                    Password = "123",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now.AddMinutes(65),
                    ModifiedUsername = $"user{i}",
                };
                context.YourStoryUsers.Add(user);
            }

            context.SaveChanges();
            List<YourStoryUser> userList = context.YourStoryUsers.ToList();
            for (int i = 0; i < 10; i++)
            {
                Category cat = new Category()
                {
                    Title = FakeData.PlaceData.GetStreetName(),
                    Description = FakeData.PlaceData.GetAddress(),
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    ModifiedUsername = "burakaydiin",
                };
                context.Categories.Add(cat);
                for (int k = 0;k< FakeData.NumberData.GetNumber(5, 9); k++)
                {
                    YourStoryUser owner = userList[FakeData.NumberData.GetNumber(0, userList.Count - 1)];
                    Story story = new Story()
                    {
                        Title = FakeData.TextData.GetAlphabetical(FakeData.NumberData.GetNumber(5, 25)),
                        Text = FakeData.TextData.GetSentences(FakeData.NumberData.GetNumber(25, 30)),
                        Category = cat,
                        IsDraft = false,
                        LikeCount = FakeData.NumberData.GetNumber(1, 9),
                        Owner = userList[FakeData.NumberData.GetNumber(0,userList.Count-1)],
                        CreatedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                        ModifiedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                        ModifiedUsername = owner.Username,

                    };
                    cat.Storys.Add(story);
                    for (int j = 0; j < FakeData.NumberData.GetNumber(3,5); j++)
                    {
                        YourStoryUser commet_owner = userList[FakeData.NumberData.GetNumber(0, userList.Count - 1)];
                        Comment comment = new Comment()
                        {
                            Text = FakeData.TextData.GetSentence(),
                            Story = story,
                            Owner = commet_owner,
                            CreatedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                            ModifiedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                            ModifiedUsername = commet_owner.Username,


                        };
                        story.Comments.Add(comment);
                        
                    }
                    
                    for (int m = 0; m < story.LikeCount; m++)
                    {
                        Liked liked = new Liked()
                        {
                            LikedUser = userList[m],
                        };
                        story.Likes.Add(liked);
                    }
                    
                }
            }
            context.SaveChanges();
        }
    }
}
