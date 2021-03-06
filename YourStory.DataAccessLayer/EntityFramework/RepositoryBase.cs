using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using YourStory.Entities;
namespace YourStory.DataAccessLayer.EntityFramework
{
    public class RepositoryBase
    {
        protected static DatabaseContext db;
        private static object _lockSync = new object();
        protected RepositoryBase()
        {
            CreateContext();
        }
        private static void  CreateContext()
        {
            if (db == null)
            {
                lock (_lockSync)
                {
                    if (db == null)
                    {
                        db = new DatabaseContext();
                    }
                }
                
            }
        }
    }
}
