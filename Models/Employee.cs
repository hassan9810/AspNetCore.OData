namespace ODataDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        [JsonIgnore]
        public Department Department { get; set; }
    }
}
