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

        [HttpGet("GetWithoutDTO")]
        [EnableQuery]
        public IActionResult GetInstructorsWithoutDTO()
        {
            var query = _instructorRepository.GetInstructorsQueryable();
            var dtoQuery = query.Select(i => new GetAllInstructorDTO
            {
                Id = i.Id,
                Name = i.Name,
                Age = i.Age,
                DeptId = i.DeptId
            });

            return Ok(dtoQuery);
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
