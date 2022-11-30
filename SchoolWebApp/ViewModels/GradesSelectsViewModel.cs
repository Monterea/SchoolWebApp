using SchoolWebApp.Models;

namespace SchoolWebApp.ViewModels {
    public class GradesSelectsViewModel {
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }
        public GradesSelectsViewModel() { 
            Students= new List<Student>();
            Subjects= new List<Subject>();
        }
    }
}
