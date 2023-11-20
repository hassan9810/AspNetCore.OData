using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using ODataDemo.DTOs;
using ODataDemo.DTOs.ResponseDTOs;
using ODataDemo.HelpersDTOs;
using ODataDemo.Models;
using ODataDemo.Service;

namespace ODataDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        private readonly IInstructorRepository _instructorRepository;
        public InstructorController(IInstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }

        [HttpGet]
        [EnableQuery]
        public Task<AllInstructorsResponseDTO> GetInstructors()
        {
            return _instructorRepository.GetInstructorsAsync();
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDTO>> PostInstructor(InstructorDTO instructorDto)
        {
            var responseDTO = await _instructorRepository.AddInstructorAsync(new Instructor
            {
                Name = instructorDto.Name,
                Age = instructorDto.Age,
                DeptId = instructorDto.DeptId
            });

            return StatusCode((int)responseDTO.StatusEnum, responseDTO);
        }
    }
}
