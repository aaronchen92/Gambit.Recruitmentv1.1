using Gambit.Recruitment.Business.Data;
using Gambit.Recruitment.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gambit.Recruitment.WebApi.Performance
{
    /// <summary>
    /// Represents the Performance service responsible of computing the performances.
    /// </summary>
    public class PerformanceService : IPerformanceService
    {
        /// <summary>
        /// Gets the performance between <paramref name="dateFrom"/> and <paramref name="dateTo"/> for the specified <paramref name="historicalValues"/>
        /// </summary>
        /// <param name="dateFrom">The date to use as start date to compute the performance.</param>
        /// <param name="dateTo">The date to use as end date to compute the performance.</param>
        /// <param name="historicalValues">The list of historical values which should be used to compute the performance.</param>
        /// <returns>The computed performance.</returns>
        public decimal GetPerformance(DateTime dateFrom, DateTime dateTo, IList<HistoricalValue> historicalValues)
        {
            try
            {
                historicalValues = historicalValues.OrderBy(x => x.Date).ToList();
                
                var p1 = historicalValues.Where(x => dateTo >= x.Date)
                    .OrderByDescending(x => x.Date)
                    .FirstOrDefault().Value;

                var p0 = historicalValues.Where(x => dateFrom >= x.Date)
                    .OrderByDescending(x => x.Date)
                    .FirstOrDefault().Value;

                var performance = (p1 - p0) / p0;

                return performance;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
