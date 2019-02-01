using Catask.DAL.Entities;
using System;
using System.Data.Entity;

namespace Catask.DAL.EF
{
    public class CataskDbInitializer : DropCreateDatabaseIfModelChanges<CataskContext>
    {
        protected override void Seed(CataskContext context)
        {
            Task firstTask = new Task
            {
                UID = Guid.NewGuid(),
                Name = "Это первая задача",
                Description = "Это описание первой задачи",
                OpenDate = DateTime.Now,
                Points = 1,
                Priority = 0
            };
            context.Tasks.Add(firstTask);
            context.Tasks.Add(new Task
            {
                UID = Guid.NewGuid(),
                Name = "Это подзадача",
                OpenDate = DateTime.Now,
                Points = 1,
                Priority = 0,
                Parent = firstTask.UID
            });
            context.SaveChanges();
        }
    }
}