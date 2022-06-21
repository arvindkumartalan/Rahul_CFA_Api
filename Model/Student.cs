using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rahul_CFA_Api.Model
{
    public class Student
    {
        [Key]
        public int RollNo { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Class { get; set; }

        [Required]
        public int Marks { get; set; }

        [Required]
        public string MobileNo { get; set; }

        public string Address { get; set; }

    }
}
