using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebJurnal.Models
{
    public class JurnalContextInitializer:DropCreateDatabaseAlways<JurnalContext>

    {
        protected override void Seed(JurnalContext db) 
        {


            Teacher th1 = new Teacher { FirstName = "Мария", SecondName = "Шевчук", DateBirth = new DateTime(1987, 12, 17) };
            Teacher th2 = new Teacher { FirstName = "Александра", SecondName = "Каримова", DateBirth = new DateTime(1977, 02, 07) };
            Teacher th3 = new Teacher { FirstName = "Ольга", SecondName = "Крылова", DateBirth = new DateTime(1980, 01, 15) };
            Teacher th4 = new Teacher { FirstName = "Анастасия", SecondName = "Строгина", DateBirth = new DateTime(1988, 06, 25) };
            Teacher th5 = new Teacher { FirstName = "Виктория", SecondName = "Смирнова", DateBirth = new DateTime(1979, 09, 14) };
            db.Teachers.AddRange(new List<Teacher> { th1, th2,th3,th4,th5 });
            db.SaveChanges();

            Class cl1 = new Class { Id=th1.Id,ClassName = "11a", CountStudents = 3 , Teacher =th1};
            Class cl2 = new Class { Id=th2.Id,ClassName = "10a", CountStudents = 4 , Teacher = th2};
            Class cl3 = new Class { Id=th3.Id,ClassName = "9a", CountStudents = 2, Teacher = th3 };
            Class cl4 = new Class { Id=th4.Id,ClassName = "8a", CountStudents = 5, Teacher = th4 };
            Class cl5 = new Class { Id=th5.Id,ClassName = "7a", CountStudents = 3, Teacher = th5 };

            db.Classes.AddRange(new List<Class> { cl1, cl2,cl3,cl4,cl5 });
            db.SaveChanges();
            //Доделать Студентов
            Student st1 = new Student { Id = 1, FirstName="Феликс",SecondName="Красильников", DateBirth=new DateTime(2001,05,13),Class=cl1 };
            Student st2 = new Student { Id = 2, FirstName="Елисей",SecondName="Навальный", DateBirth=new DateTime(2001,03,25),Class=cl1 };
            Student st3 = new Student { Id = 3, FirstName="Закир",SecondName="Савельев", DateBirth=new DateTime(2001,02,28),Class=cl1 };
            Student st4 = new Student { Id = 4, FirstName="Сава",SecondName="Борисов", DateBirth=new DateTime(2002,05,26),Class=cl2 };
            Student st5 = new Student { Id = 5, FirstName="Абрам",SecondName="Ковалёв", DateBirth=new DateTime(2002,12,03),Class=cl2 };
            Student st6 = new Student { Id = 6, FirstName="Аким",SecondName="Житар", DateBirth=new DateTime(2002,11,15),Class=cl2 };
            Student st7 = new Student { Id = 7, FirstName="Станислав",SecondName="Зуев", DateBirth=new DateTime(2002,03,18),Class=cl2 };
            Student st8 = new Student { Id = 8, FirstName="Гавриил",SecondName="Рябов", DateBirth=new DateTime(2003,08,23),Class=cl3 };
            Student st9 = new Student { Id = 9, FirstName="Яромир",SecondName="Лукин", DateBirth=new DateTime(2003,09,05),Class=cl3 };
            Student st10 = new Student { Id = 10, FirstName="Родион",SecondName="Яловой", DateBirth=new DateTime(2003,07,09),Class=cl4 };
            Student st11 = new Student { Id = 11, FirstName="Станислав",SecondName="Гончар", DateBirth=new DateTime(2004,04,15),Class=cl4 };
            Student st12 = new Student { Id = 12, FirstName="Иомер",SecondName="Виноградов", DateBirth=new DateTime(2004,01,20),Class=cl4 };
            Student st13 = new Student { Id = 13, FirstName="Ждан",SecondName="Толочко", DateBirth=new DateTime(2004,01,10),Class=cl4 };
            Student st14 = new Student { Id = 14, FirstName="Ираклий",SecondName="Уваров", DateBirth=new DateTime(2004,02,23),Class=cl4};
            Student st15 = new Student { Id = 15, FirstName="Эдуард",SecondName="Рожков", DateBirth=new DateTime(2005,06,03),Class=cl5 };
            Student st16 = new Student { Id = 16, FirstName="Пётр",SecondName="Мухин", DateBirth=new DateTime(2005,08,14),Class=cl5 };
            Student st17 = new Student { Id = 17, FirstName="Дарий",SecondName="Казаков", DateBirth=new DateTime(2005,10,01),Class=cl5 };
            db.Students.AddRange(new List<Student> { st1, st2, st3, st4, st5, st6, st7, st8, st9, st10, st11, st12, st13, st14, st15, st16, st17 });
            db.SaveChanges();

            Subject sub1 = new Subject { Name="Русский язык", Id = th1.Id};
            Subject sub2 = new Subject { Name="Физика", Id = th2.Id};
            Subject sub3 = new Subject { Name="История", Id = th3.Id};
            Subject sub4 = new Subject { Name="Математика", Id = th4.Id};
            Subject sub5 = new Subject { Name="Информатика", Id = th5.Id};
            db.SaveChanges();
            #region sub1.Students.Add(st1);
            sub1.Students.Add(st2);
            sub1.Students.Add(st3);
            sub1.Students.Add(st4);
            sub1.Students.Add(st5);
            sub1.Students.Add(st6);
            sub1.Students.Add(st7);
            sub1.Students.Add(st8);
            sub1.Students.Add(st9);
            sub1.Students.Add(st10);
            sub1.Students.Add(st11);
            sub1.Students.Add(st12);
            sub1.Students.Add(st13);
            sub1.Students.Add(st14);
            sub1.Students.Add(st15);
            sub1.Students.Add(st16);
            sub1.Students.Add(st17);
            #endregion
            #region sub2.Students.Add(st1);
            sub2.Students.Add(st2);
            sub2.Students.Add(st3);
            sub2.Students.Add(st4);
            sub2.Students.Add(st5);
            sub2.Students.Add(st6);
            sub2.Students.Add(st7);
            sub2.Students.Add(st8);
            sub2.Students.Add(st9);
            #endregion
            #region sub3.Students.Add(st1);
            sub3.Students.Add(st2);
            sub3.Students.Add(st3);
            sub3.Students.Add(st4);
            sub3.Students.Add(st5);
            sub3.Students.Add(st6);
            sub3.Students.Add(st7);
            sub3.Students.Add(st8);
            sub3.Students.Add(st9);
            sub3.Students.Add(st10);
            sub3.Students.Add(st11);
            sub3.Students.Add(st12);
            sub3.Students.Add(st13);
            sub3.Students.Add(st14);
            sub3.Students.Add(st15);
            sub3.Students.Add(st16);
            sub3.Students.Add(st17);
            #endregion
            #region sub4.Students.Add(st1);
            sub4.Students.Add(st2);
            sub4.Students.Add(st3);
            sub4.Students.Add(st4);
            sub4.Students.Add(st5);
            sub4.Students.Add(st6);
            sub4.Students.Add(st7);
            sub4.Students.Add(st8);
            sub4.Students.Add(st9);
            sub4.Students.Add(st10);
            sub4.Students.Add(st11);
            sub4.Students.Add(st12);
            sub4.Students.Add(st13);
            sub4.Students.Add(st14);
            sub4.Students.Add(st15);
            sub4.Students.Add(st16);
            sub4.Students.Add(st17);
            #endregion
            #region sub5.Students.Add(st1);
            sub5.Students.Add(st2);
            sub5.Students.Add(st3);
            sub5.Students.Add(st4);
            sub5.Students.Add(st5);
            sub5.Students.Add(st6);
            sub5.Students.Add(st7);
            sub5.Students.Add(st8);
            sub5.Students.Add(st9);
            #endregion

            db.Subjects.AddRange(new List<Subject> { sub1, sub2, sub3, sub4, sub5 });
            db.SaveChanges();
            //+записать ученикам предметы
            base.Seed(db);
        }
    }
}