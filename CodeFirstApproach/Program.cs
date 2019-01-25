using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproach
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                //using (var db = new StudentDB())
                //{
                //    var student1 = new student() { Name = "Oshan", StudentId = "IT15037084", NIC = "95297506V", phone = 0771884780 };
                //    var student2 = new student() { Name = "janith", StudentId = "IT15054445", NIC = "97757668V", phone = 0757874354 };
                //    var student3 = new student() { Name = "pavan", StudentId = "IT15234252", NIC = "9545235V", phone = 0774353452 };
                //    var student4 = new student() { Name = "pubudu", StudentId = "IT342432423", NIC = "32423423v", phone = 0773242342 };
                //    var student5 = new student() { Name = "udara", StudentId = "IT3452354", NIC = "93453454V", phone = 077345135 };
                //    var student6 = new student() { Name = "mashitha", StudentId = "IT2342343", NIC = "32423424V", phone = 0773242553 };
                //    var student7 = new student() { Name = "meesha", StudentId = "IT23423423", NIC = "23423423V", phone = 0773242421 };
                //    var student8 = new student() { Name = "Jayani", StudentId = "IT42324524", NIC = "32424234V", phone = 0774533453 };
                //    var student9 = new student() { Name = "Rukshani", StudentId = "IT23452353", NIC = "546363434V", phone = 342342344 };

                //    var sub1 = new Subject() { SubjectName = "Mathematics", SubjectCode = "ma123" };
                //    var sub2 = new Subject() { SubjectName = "English", SubjectCode = "en123" };
                //    var sub3 = new Subject() { SubjectName = "probability", SubjectCode = "pro123" };
                //    var sub4 = new Subject() { SubjectName = "Statictics", SubjectCode = "st123" };
                //    var sub5 = new Subject() { SubjectName = "Programming", SubjectCode = "prg123" };
                //    var sub6 = new Subject() { SubjectName = "Software engineering", SubjectCode = "se123" };
                //    var sub7 = new Subject() { SubjectName = "Project", SubjectCode = "prj123" };

                //    var fac1 = new faculty() { Dean = "Oshan Mendis", FacultyName = "Information Technology" };
                //    var fac2 = new faculty() { Dean = "Paduma Wijenayake", FacultyName = "Engineering" };
                //    var fac3 = new faculty() { Dean = "Lahiru Perera", FacultyName = "Business" };



                //    student1.Subjects.Add(sub1);
                //    student2.Subjects.Add(sub2);
                //    student3.Subjects.Add(sub3);
                //    student4.Subjects.Add(sub4);
                //    student5.Subjects.Add(sub4);
                //    student6.Subjects.Add(sub5);
                //    student7.Subjects.Add(sub6);
                //    student8.Subjects.Add(sub7);
                //    student9.Subjects.Add(sub7);



                //    db.Students.Add(student1);
                //    db.Students.Add(student2);
                //    db.Students.Add(student3);
                //    db.Students.Add(student4);
                //    db.Students.Add(student5);
                //    db.Students.Add(student6);
                //    db.Students.Add(student7);
                //    db.Students.Add(student8);
                //    db.Students.Add(student9);

                //    db.Faculties.Add(fac1);
                //    db.Faculties.Add(fac2);
                //    db.Faculties.Add(fac3);



                //    db.SaveChanges();
                //}
            }

            catch (Exception e)
            {
                Console.WriteLine("Database is already avaailable or connection failed");
            }



            
        }
    }
}
