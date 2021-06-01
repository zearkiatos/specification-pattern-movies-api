using System;
using Xunit;
using System.Collections.Generic;
using MoviesApi.Shared.Domain.Criterials;
namespace MoviesApi.Tests.Shared.Domain.Criterials
{
    public class CriteriaUnitTest
    {
        [Fact]
        public void Should_DeclarateCriteria_And_Return_Associate_Data()
        {
            List<Filter> filters = new List<Filter>();
            filters.Add(new Filter{FilterField = "filter1", FilterOperator = "==", FilterValue = "1" });
            filters.Add(new Filter{FilterField = "filter2", FilterOperator = "<>", FilterValue = "2" });
            string order = "ascendent";
            int offset = 20;
            int limit = 100;

            Criteria criteria = new Criteria(filters, order, offset, limit);

            Assert.True(criteria.HasFilters());
            Assert.True(criteria.HasOrder());
            Assert.Equal(criteria.PlainFilters().Length,2);
            Assert.Equal(criteria.Serialize(), "filter1 == 1,filter2 <> 2,~~ascendent~~20~~100");
        }

        [Fact]
        public void Should_Return_False_If_Criteria_DoNotHave_Filters()
        {
            int offset = 20;
            int limit = 100;

            Criteria criteria = new Criteria(null, "", offset, limit);

            Assert.False(criteria.HasFilters());
            Assert.Equal(criteria.PlainFilters().Length,0);
            Assert.Equal(criteria.Serialize(), "20~~100");
        }

        [Fact]
        public void Should_Return_False_If_Criteria_DoNotHave_Orders()
        {
            List<Filter> filters = new List<Filter>();
            filters.Add(new Filter{FilterField = "filter1", FilterOperator = "==", FilterValue = "1" });
            filters.Add(new Filter{FilterField = "filter2", FilterOperator = "<>", FilterValue = "2" });
            int offset = 4;
            int limit = 5;

            Criteria criteria = new Criteria(filters, "", offset, limit);

            Assert.True(criteria.HasFilters());
            Assert.False(criteria.HasOrder());
            Assert.Equal(criteria.PlainFilters().Length,2);
            Assert.Equal(criteria.Serialize(), "filter1 == 1,filter2 <> 2,~~4~~5");
        }
    }
}