using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_RSI.DA
{
    public class Schedule
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int YearOfProduction { get; set; }

        public int Duration { get; set; }

        public DateTime AiringStart { get; set; }

        public Genre Genre { get; set; }

    }
}
