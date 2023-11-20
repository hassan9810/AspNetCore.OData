using ODataDemo.DTOs.ResponseDTOs;

namespace ODataDemo.HelpersDTOs
{
    public class AllInstructorsResponseDTO : BasicResponseDTO
    {
        public IEnumerable<GetAllInstructorDTO> Result { get; set; }
    }
}
