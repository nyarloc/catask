using Catask.DAL.Entities;
using System;
using System.Data.Entity;

namespace Catask.DAL.EF
{
    public class CataskDbInitializer : DropCreateDatabaseIfModelChanges<CataskContext>
    {
        protected override void Seed(CataskContext context)
        {
            context.Priorities.Add(new Priority { ID = 0, Name = "Нужно вчера" });
            context.Priorities.Add(new Priority { ID = 1, Name = "Горит" });
            context.Priorities.Add(new Priority { ID = 2, Name = "Важно" });
            context.Priorities.Add(new Priority { ID = 3, Name = "Обычная" });
            context.Priorities.Add(new Priority { ID = 4, Name = "Подождет" });

            Task firstTask = new Task
            {
                UID = Guid.NewGuid(),
                Description = "Это первая задача",
                OpenDate = DateTime.Now,
                Points = 1,
                Priority = new Priority { ID = 3, Name = "Обычная" }
            };
            context.Tasks.Add(firstTask);
            context.Tasks.Add(new Task
            {
                UID = Guid.NewGuid(),
                Description = "Это первая подзадача",
                OpenDate = DateTime.Now,
                Points = 1,
                Priority = new Priority { ID = 0, Name = "Не задан"},
                Parent = firstTask
            });
            context.SaveChanges();
        }
    }
}