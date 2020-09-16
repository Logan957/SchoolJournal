using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebJurnal.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime DateBirth { get; set; }
        public Class ClassId { get; set; }
        public Subject SubjectId { get; set; }
        

    }
}