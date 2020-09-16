using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebJurnal.Models
{
    public class Subject
    {
        [Key]
        [ForeignKey("Teacher")]
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Student> Students { get; set; }
        public Subject() 
        {
            Students = new List<Student>();
        }

    }
}