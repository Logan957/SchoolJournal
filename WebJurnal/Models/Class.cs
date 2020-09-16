using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebJurnal.Models
{
    public class Class
    {
        [Key]
        [ForeignKey("Teacher")]
        public int Id { get; set; }
        public string ClassName { get; set; }
        public int CountStudents { get; set; }
        public ICollection<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
        public Class() 
        {
            Students = new List<Student>();

          
        }
    }
}