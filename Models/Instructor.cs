using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ODataDemo.Models
{
    public class Instructor
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
