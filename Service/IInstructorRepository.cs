namespace ODataDemo.Service
{
    public interface IInstructorRepository
    {
        Task<AllInstructorsResponseDTO> GetInstructorsAsync();
        Task<ResponseDTO> AddInstructorAsync(Instructor instructor);
        IQueryable<Instructor> GetInstructorsQueryable();
    }
}
