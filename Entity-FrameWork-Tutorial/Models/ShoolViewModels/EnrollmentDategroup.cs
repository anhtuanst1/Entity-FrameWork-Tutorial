using System;
using System.ComponentModel.DataAnnotations;

namespace Entity_FrameWork_Tutorial.Models.ShoolViewModels
{
    public class EnrollmentDategroup
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public int StudentCount { get; set; }
    }
}
