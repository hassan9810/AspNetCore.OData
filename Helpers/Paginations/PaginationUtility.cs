namespace ODataDemo.Helpers.Paginations
{
    public static class PaginationUtility
    {
        public static async Task<PaginatedList<T>> Paging<T>(PaginatedInputModel pagingParams, List<T> data)
        {
            #region [Filter]
            if (pagingParams != null && pagingParams.FilterParam != null && pagingParams.FilterParam.Any())
            {
                data = FilterUtility.Filter<T>.FilteredData(pagingParams.FilterParam, data).ToList() ?? data;
            }
            #endregion

            #region [Sorting]
            if (pagingParams != null && pagingParams.SortingParams != null && pagingParams.SortingParams.Count() > 0)
            {
                data = SortingUtility.Sorting<T>.SortData(data, pagingParams.SortingParams).ToList();
            }

            #endregion

            #region [Grouping]
            if (pagingParams != null && pagingParams.GroupingColumns != null && pagingParams.GroupingColumns.Count() > 0)
            {
                data = SortingUtility.Sorting<T>.GroupingData(data, pagingParams.GroupingColumns).ToList() ?? data;
            }
            #endregion

            #region [Paging]
            return await PaginatedList<T>.CreateAsync(data, pagingParams.PageNumber, pagingParams.PageSize);
            #endregion
        }
    }
}
