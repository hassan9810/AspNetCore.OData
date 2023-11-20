using static ODataDemo.Helpers.Enums.Enums;

namespace ODataDemo.DTOs.ResponseDTOs
{
    public abstract class BasicResponseDTO
    {
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
        public int TotalItems { get; set; }
        public int PageSize { get; set; }
        public string Message { get; set; }

        public StatusEnum StatusEnum { get; set; }
    }
}
