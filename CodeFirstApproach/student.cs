using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproach
{
    public class student
    {
        private static int counter;

        //public student()
        //{
        //    counter++;
        //}

        public static int getNumOfInstances()
        {
            return counter;
        }
        
        [Key]
        public string StudentId { get; set; }

        public string Name { get; set; }

        public string NIC { get; set; }

        public int phone { get; set; }

       // public virtual faculty Faculties { get; set; }

        public virtual IList<Subject> Subjects { get; set; }

        public student()
        {
            this.Subjects = new List<Subject>();
            counter++;
        }
     
    }
}
