using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_RSI.DA
{
    public class DataContext
    {
        public List<Schedule> Schedules { get; private set; }

        public DataContext()
        {
            Schedules = new List<Schedule>
            {
                new Schedule()
                {
                     AiringStart = DateTime.Today,
                     Duration = 20,
                     Genre = Genre.Series,
                     Id = 0,
                     Title = "Two and a Half Men",
                     YearOfProduction = 2010
                },

                new Schedule()
                {
                     AiringStart = new DateTime(2018, 1, 1, 20, 0, 0),
                     Duration = 30,
                     Genre = Genre.Information,
                     Id = 1,
                     Title = "Telegiornale",
                     YearOfProduction = 2018
                },

                new Schedule()
                {
                     AiringStart = new DateTime(2018, 1, 1, 20, 35, 0),
                     Duration = 25,
                     Genre = Genre.Variety,
                     Id = 2,
                     Title = "Via Col Venti",
                     YearOfProduction = 2018
                },

                new Schedule()
                {
                     AiringStart = new DateTime(2018, 1, 1, 21, 35, 0),
                     Duration = 45,
                     Genre = Genre.Series,
                     Id = 3,
                     Title = "Cobra 11",
                     YearOfProduction = 2018
                },

                new Schedule()
                {
                     AiringStart = new DateTime(2018, 1, 1, 19, 45, 0),
                     Duration = 7,
                     Genre = Genre.Variety,
                     Id = 4,
                     Title = "Il Rompiscatole",
                     YearOfProduction = 2018
                }
            };
        }
    }
}
