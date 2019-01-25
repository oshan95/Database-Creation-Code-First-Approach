using System.Data.Entity;

namespace CodeFirstApproach
{
    class StudentDB : DbContext
    {
        public DbSet<student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<faculty> Faculties { get; set; }

        public DbSet<Patient> Patient { get; set; }

        public DbSet<PatientAddress> PatientAddress { get; set; }

        public DbSet<TestTable> Test { get; set; }

    }
}
