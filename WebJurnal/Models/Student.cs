using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebJurnal.Models
{
    public class Student
    {
     public int Id { get; set; }
     public string FirstName { get; set; }
     public string SecondName { get; set; }
     public DateTime DateBirth { get; set; }
     public int? ClassId { get; set; }
     public Class Class { get; set; }
     public ICollection<Subject> Subjects { get; set; }
     public Student() 
       {
            Subjects = new List<Subject>(); 
       } 
    }
}