namespace ODataDemo.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Instructor> Instructors { get; set; }

    }
}
