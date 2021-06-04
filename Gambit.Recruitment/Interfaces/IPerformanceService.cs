using Gambit.Recruitment.Business.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gambit.Recruitment.Business.Interfaces
{
    public interface IPerformanceService
    {
        decimal GetPerformance(DateTime dateFrom, DateTime dateTo, IList<HistoricalValue> historicalValues);
    }
}
