using Gambit.Recruitment.Business.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gambit.Recruitment.WebApi.Utility
{
    public static class Initializer
    {
        public static IList<HistoricalValue> Initiate()
        {
            var list = new List<HistoricalValue>()
            {
                new HistoricalValue(new DateTime(2021, 5, 1), 2),
                new HistoricalValue(new DateTime(2021, 5, 2), 12),
                new HistoricalValue(new DateTime(2021, 5, 3), 32),
                new HistoricalValue(new DateTime(2021, 5, 4), 44),
                new HistoricalValue(new DateTime(2021, 5, 4), 44),
                new HistoricalValue(new DateTime(2021, 5, 5), 22),
                new HistoricalValue(new DateTime(2021, 5, 6), 24),
                new HistoricalValue(new DateTime(2021, 5, 7), 26),
                new HistoricalValue(new DateTime(2021, 5, 8), 42),
                new HistoricalValue(new DateTime(2021, 5, 9), 64),
                new HistoricalValue(new DateTime(2021, 5, 10), 22),
                new HistoricalValue(new DateTime(2021, 5, 11), 28),
                //new HistoricalValue(new DateTime(2021, 5, 12), 12),
                new HistoricalValue(new DateTime(2021, 5, 13), 14),
                new HistoricalValue(new DateTime(2021, 5, 14), 18),
                new HistoricalValue(new DateTime(2021, 5, 15), 24),
                new HistoricalValue(new DateTime(2021, 5, 16), 26),
                new HistoricalValue(new DateTime(2021, 5, 17), 28),
                new HistoricalValue(new DateTime(2021, 5, 18), 30),
                new HistoricalValue(new DateTime(2021, 5, 19), 28),
                new HistoricalValue(new DateTime(2021, 5, 20), 22),
                new HistoricalValue(new DateTime(2021, 5, 21), 26),
                new HistoricalValue(new DateTime(2021, 5, 22), 42),
                new HistoricalValue(new DateTime(2021, 5, 22), 38),
                new HistoricalValue(new DateTime(2021, 5, 23), 36),
                new HistoricalValue(new DateTime(2021, 5, 24), 34),
                new HistoricalValue(new DateTime(2021, 5, 25), 32),
                new HistoricalValue(new DateTime(2021, 5, 26), 30),
                new HistoricalValue(new DateTime(2021, 5, 27), 22),
                new HistoricalValue(new DateTime(2021, 5, 28), 26),
                new HistoricalValue(new DateTime(2021, 5, 29), 28),
                new HistoricalValue(new DateTime(2021, 5, 30), 10),
                new HistoricalValue(new DateTime(2021, 5, 31), 6)
            };

            return list;
        }
    }
}
