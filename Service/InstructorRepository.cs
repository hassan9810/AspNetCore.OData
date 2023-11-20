using Microsoft.EntityFrameworkCore;
using ODataDemo.Context;
using ODataDemo.DTOs.ResponseDTOs;
using ODataDemo.HelpersDTOs;
using ODataDemo.Models;
using static ODataDemo.Helpers.Enums.Enums;

namespace ODataDemo.Service
{
    public class InstructorRepository : IInstructorRepository
    {
        private readonly ApplicationDbContext _context;
        public InstructorRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<AllInstructorsResponseDTO> GetInstructorsAsync()
        {
            try
            {
                var instructors = await _context.Instructors
                    .Include(e => e.Department)
                    .Select(i => new GetAllInstructorDTO
                    {
                        Id = i.Id,
                        Name = i.Name,
                        Age = i.Age,
                        DeptId = i.DeptId
                    })
                    .ToListAsync();

                return new AllInstructorsResponseDTO
                {
                    Message = "Successfully retrieved instructors",
                    StatusEnum = StatusEnum.Success,
                    Result = instructors
                };
            }
            catch (Exception ex)
            {
                return new AllInstructorsResponseDTO
                {
                    Message = "Error retrieving instructors",
                    StatusEnum = StatusEnum.Failed,
                    Result = null
                };
            }
        }
        public async Task<ResponseDTO> AddInstructorAsync(Instructor instructor)
        {
            try
            {
                _context.Instructors.Add(instructor);
                await _context.SaveChangesAsync();

                return new ResponseDTO
                {
                    Message = "Instructor created successfully",
                    StatusEnum = StatusEnum.Success,
                    Result = instructor
                };
            }
            catch (Exception ex)
            {
                return new ResponseDTO
                {
                    Message = "Error creating instructor",
                    StatusEnum = StatusEnum.FailedToSave,
                    Result = ex.Message
                };
            }
        }
    }
}
