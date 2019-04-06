namespace Entity_FrameWork_Tutorial.Models
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
        public Grade? Grade { get; set; }       //Can set NULL
        public Course Course { get; set; }      // Class Course in Models
        public Student Student { get; set; }    // Class Student in Models
    }
}