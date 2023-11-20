using static ODataDemo.Helpers.Enums.Enums;

namespace ODataDemo.Helpers.GenericSearchFilter
{
    /// <summary>
    /// Filter parameters Model Class
    /// </summary>
    public class FilterParams
    {
        public string ColumnName { get; set; } = string.Empty;
        public string FilterValue { get; set; } = string.Empty;
        public FilterOptions FilterOption { get; set; } = FilterOptions.Contains;
    }
}
