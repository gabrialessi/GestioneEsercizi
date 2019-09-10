using _08_CoffeeShop.DA.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CoffeeShop.DA.Service
{
    public class CoffeeDataRepository : IDataRepository<Coffee>
    {
        private static DataContext ctx;

        public CoffeeDataRepository()
        {
            ctx = new DataContext();
        }

        public void Delete(Coffee entity)
        {
            ctx.Coffees.Remove(entity);
        }

        public Coffee Get(int id)
        {
            return ctx.Coffees.Where(c => c.CoffeeId == id).FirstOrDefault();
            //return ctx.Coffees.FirstOrDefault(c => c.CoffeeId == id);
        }

        public IEnumerable<Coffee> Get()
        {
            return ctx.Coffees;
        }

        public Coffee Insert(Coffee entity)
        {
            int newId = ctx.Coffees.Max(c => c.CoffeeId) + 1;
            entity.CoffeeId = newId;
            ctx.Coffees.Add(entity);
            return entity;
        }

        public int Update(Coffee entity)
        {
            Coffee c = Get(entity.CoffeeId);
            return int.MinValue;
        }
    }
}
