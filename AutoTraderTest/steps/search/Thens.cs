using AutoTraderTest.pages.pagechecks;
using System;
using TechTalk.SpecFlow;

namespace AutoTraderTest.steps.search
{
    [Binding]
    class Thens
    {
        [Then(@"search (.+) are shown")]
        public void ThenSearchCategoriesAreShown(String categories)
        {
            SearchOptionsChecks.CheckSearchCategories(categories);
        }

    }
}
