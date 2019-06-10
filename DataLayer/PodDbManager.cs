using System;
using System.Linq;
using DataModel;

namespace DataLayer
{
    public class PodDbManager : IPodDbManager
    {
        private KSDbContext DBContext { get; }

        public PodDbManager(KSDbContext dbContext)
        {
            DBContext = dbContext;
        }

        public Pod GetPod()
        {
            return DBContext.Pods.First();
        }

        public void AddPod(Pod entity)
        {
            DBContext.Add(entity);
            DBContext.SaveChanges();
        }
    }
}
