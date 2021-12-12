﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourStory.BusinessLayer
{
    public class RepositoryBase
    {
        protected static DataAccessLayer.DatabaseContext db;
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
                        db = new DataAccessLayer.DatabaseContext();
                    }
                }
                
            }
        }
    }
}
