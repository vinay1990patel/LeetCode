using System.ComponentModel.DataAnnotations.Schema;

namespace MixSample.Model
{
    public class Employee
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
    }
}
