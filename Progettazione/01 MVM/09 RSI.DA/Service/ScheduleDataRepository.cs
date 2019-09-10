using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_RSI.DA.Service
{
    public class ScheduleDataRepository : IDataRepository<Schedule>
    {
        private static DataContext ctx;

        public ScheduleDataRepository()
        {
            ctx = new DataContext();
        }

        public void Delete(Schedule entity)
        {
            ctx.Schedules.Remove(entity);
        }

        public Schedule Get(int id)
        {
            return ctx.Schedules.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Schedule> Get()
        {
            return ctx.Schedules;
        }

        public Schedule Insert(Schedule entity)
        {
            int newId = ctx.Schedules.Max(s => s.Id) + 1;
            entity.Id = newId;
            ctx.Schedules.Add(entity);
            return entity;
        }

        public int Update(Schedule entity)
        {
            throw new NotImplementedException();
        }
    }
}
