using System;
using System.Collections.Generic;
using System.Linq;
using DataModel;

namespace DataLayer
{
    public class PodDbManager : IPodDbManager
    {
        private readonly KSDbContext KsDbContext;

        public PodDbManager(KSDbContext dbContext)
        {
            KsDbContext = dbContext;
        }

        public List<Pod> GetPod()
        {
            var pod = KsDbContext.PodKnowledge.ToList();
            return pod;
        }

        public void AddPod(Pod entity)
        {
            KsDbContext.PodKnowledge.Add(entity);
            KsDbContext.SaveChanges();
        }
    }
}
