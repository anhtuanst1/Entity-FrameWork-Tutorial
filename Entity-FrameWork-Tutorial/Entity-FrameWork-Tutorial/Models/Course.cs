using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity_FrameWork_Tutorial.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }    //Thuoc tinh Enrollments cua Course entity se chua tat ca Enrollment co lien quan den Course do.
    }
}
