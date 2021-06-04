using Gambit.Recruitment.Business;
using Gambit.Recruitment.Business.Data;
using Gambit.Recruitment.WebApi.Performance;
using System;
using System.Collections.Generic;
using Xunit;

namespace Gambit.Recruitment.Business.Tests.Performance
{

    /// <summary>
    /// Represents the <see cref="PerformanceService"/>> test class.
    /// </summary>
    public class PerformanceServiceTest
    {
        [Fact]
        public void GetPerformanceExactResult()
        {
            //Arrange
            var mockedData = Initiate();
            var performanceService = new PerformanceService();

            //Act
            var result = performanceService.GetPerformance(new DateTime(2021, 1, 2), new DateTime(2021, 1, 4), mockedData);
            var result2 = performanceService.GetPerformance(new DateTime(2021, 1, 6), new DateTime(2021, 1, 2), mockedData);

            //Assert
            Assert.IsType<decimal>(result);
            Assert.Equal(result, 1);
            Assert.Equal(result2, -0.6667m, 4);
        }

        [Fact]
        public void GetPerformanceNegativeResult()
        {
            //Arrange
            var mockedData = Initiate();
            var performanceService = new PerformanceService();

            //Act
            var result = performanceService.GetPerformance(new DateTime(2021, 1, 4), new DateTime(2021, 1, 2), mockedData);

            //Assert
            Assert.IsType<decimal>(result);
            Assert.True(result < 0);
        }

        [Fact]
        public void GetPerformanceExceptionResult()
        {
            //Arrange
            var mockedData = Initiate();
            var performanceService = new PerformanceService();

            //Act & Assert
            Assert.Throws<NullReferenceException>(() => performanceService.GetPerformance(new DateTime(2020, 1, 1), new DateTime(2021, 1, 2), mockedData));
        }


        public static IList<HistoricalValue> Initiate()
        {
            //var list = new List<HistoricalValue>();
            //for (int i = 1; i < 15; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        list.Add(new HistoricalValue(new DateTime(2021, 1, i), i * 2));
            //    }
            //}
            var list = new List<HistoricalValue>()
            {
                new HistoricalValue(new DateTime(2021, 1, 1), 2),
                new HistoricalValue(new DateTime(2021, 1, 2), 4),
                new HistoricalValue(new DateTime(2021, 1, 3), 6),
                new HistoricalValue(new DateTime(2021, 1, 4), 8),
                new HistoricalValue(new DateTime(2021, 1, 5), 10),
                new HistoricalValue(new DateTime(2021, 1, 6), 12),
                new HistoricalValue(new DateTime(2021, 1, 7), 14),
            };

            return list;
        }
    }
}
