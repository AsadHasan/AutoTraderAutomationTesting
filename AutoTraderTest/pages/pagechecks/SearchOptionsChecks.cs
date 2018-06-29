using AutoTraderTest.helpers;
using FluentAssertions;
using System.Linq;

namespace AutoTraderTest.pages.pagechecks
{
    class SearchOptionsChecks
    {
        public static void CheckSearchCategories(string searchCategories)
        {
            var actualCategories = new SearchOptions(DriverHelper.GetWebDriver()).SearchCategories.Select(e=>e.Text);
            var expectedCategories = searchCategories.Split(',').ToList();
            actualCategories.Should().BeEquivalentTo(expectedCategories);
        }
    }
}
