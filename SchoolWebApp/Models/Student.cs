using System.ComponentModel.DataAnnotations;

namespace SchoolWebApp.Models {
    public class Student {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //[DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
