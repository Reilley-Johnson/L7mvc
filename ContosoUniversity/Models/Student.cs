//tinfo200:[2021-03-13-<rfj4>-dykstra1] Added code directly from tutorial. Sets ID property as the primary key of the database table of this class. Enrollment is used for navigation purposes.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
