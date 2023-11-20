using ODataDemo.DTOs.ResponseDTOs;
using ODataDemo.HelpersDTOs;
using ODataDemo.Models;

namespace ODataDemo.Service
{
    public interface IInstructorRepository
    {
        Task<AllInstructorsResponseDTO> GetInstructorsAsync();
        Task<ResponseDTO> AddInstructorAsync(Instructor instructor);
    }
}
