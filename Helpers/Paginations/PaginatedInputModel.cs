using ODataDemo.Helpers.GenericSearchFilter;
using ODataDemo.Helpers.GenericSort;

namespace ODataDemo.Helpers.Paginations
{
    public class PaginatedInputModel
    {
        public IEnumerable<SortingParams> SortingParams { set; get; }
        public IEnumerable<FilterParams> FilterParam { get; set; }
        public IEnumerable<string> GroupingColumns { get; set; } = null;
        int pageNumber = 1;
        public int PageNumber { get { return pageNumber; } set { if (value > 1) { pageNumber = value; } } }

        int pageSize = 9;
        public int PageSize { get { return pageSize; } set { if (value > 1) { pageSize = value; } } }

        public PaginatedInputModel()
        {
        }
    }
}