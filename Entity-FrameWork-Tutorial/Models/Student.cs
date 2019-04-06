using System;
using System.Collections.Generic;

namespace Entity_FrameWork_Tutorial.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } //Thuoc tinh Enrollments cua Student entity se chua tat ca Enrollment co lien quan den Student do.
    }
}
