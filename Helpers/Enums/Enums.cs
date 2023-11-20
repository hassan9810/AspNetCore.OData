namespace ODataDemo.Helpers.Enums
{
    public class Enums
    {
        public enum StatusEnum
        {
            FailedToSave,
            SavedSuccessfully,
            Exception,
            Success,
            Failed,
            FailedToFindTheObject,
            AlreadyExisting
        }
        public enum SortOrders
        {
            Asc = 1,
            Desc = 2
        }
        public enum FilterOptions
        {
            StartsWith = 1,
            EndsWith,
            Contains,
            DoesNotContain,
            IsEmpty,
            IsNotEmpty,
            IsGreaterThan,
            IsGreaterThanOrEqualTo,
            IsLessThan,
            IsLessThanOrEqualTo,
            IsEqualTo,
            IsNotEqualTo
        }
    }
}
