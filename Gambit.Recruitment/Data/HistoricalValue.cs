using System;

namespace Gambit.Recruitment.Business.Data
{
    /// <summary>
    /// Represents a Historical value
    /// </summary>
    public class HistoricalValue
    {
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public decimal Value { get; set; }
        public Boolean IsBusinessDay { get; set; }

        public HistoricalValue(DateTime Date, decimal Value)
        {
            this.Date = Date;
            this.Value = Value;
        }
    }
}
