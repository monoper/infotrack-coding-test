using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using infotrack_coding_test.services.interfaces;
using infotrack_coding_test.extensions;
using infotrack_coding_test.Controllers;
using infotrack_coding_test.Models;

namespace infotrack_coding_tests.tests {
    public class SearchControllerTests {
        [Fact]
        public void GETSearchTest()
        {
            var mockSearchService = new Mock<ISearchService>();

            var controller = new SearchController(mockSearchService.Object);

            var result = controller.Search();

            var resultType = Assert.IsType<ViewResult>(result);
            Assert.IsAssignableFrom<SearchViewModel>(resultType.ViewData.Model);
        }
    }
}