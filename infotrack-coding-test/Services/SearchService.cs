using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using infotrack_coding_test.dto;
using infotrack_coding_test.services.interfaces;
using infotrack_coding_test.extensions;

namespace infotrack_coding_test.services
{
    public class SearchService : ISearchService
    {
        private readonly IParseSearchResponseService _parseService;

        public SearchService(IParseSearchResponseService parseService)
        {
            _parseService = parseService;
        }
        public async Task<SearchResultDTO> Search(string searchUrl, string[] keywords)
        {
            SearchResultDTO searchResultDto = new SearchResultDTO();

            using(var httpClient = new HttpClient()){
                var searchString = keywords.ToSearchString();
                
                var response = await httpClient.GetStringAsync($"https://www.google.com.au/search?q={searchString}&num=100");
                
                var positions = (await _parseService.ParseResponseBody(response)).FindAllIndices(searchUrl);

                searchResultDto = new SearchResultDTO(){
                    SearchPositions = positions
                };
            }

            return searchResultDto;
        }
    }
}