//tinfo200:[2021-03-13-<rfj4>-dykstra1] Added this class directly from the tutorial. EnrollemtID is the primary key. This uses the classnameID pattern over the regular ID pattern. The grade property is an enum and is found to be nullable. 
// The StudentID and CourseID are both foreign keys in this class. Both are used for navigation purposes where each of their respective navigation properties are Student and Course.

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }

    }
}