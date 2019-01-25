namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.students",
                c => new
                    {
                        StudentId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        NIC = c.String(),
                        phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectCode = c.String(nullable: false, maxLength: 128),
                        SubjectName = c.String(nullable: false, maxLength: 128),
                        student_StudentId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.SubjectCode, t.SubjectName })
                .ForeignKey("dbo.students", t => t.student_StudentId, cascadeDelete: true)
                .Index(t => t.student_StudentId);
            
            CreateTable(
                "dbo.faculties",
                c => new
                    {
                        FacultyName = c.String(nullable: false, maxLength: 128),
                        Dean = c.String(),
                        NoOfStudents = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FacultyName);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        AddressId = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Gender = c.String(nullable: false, maxLength: 1),
                        ContactNo = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.PId)
                .ForeignKey("dbo.PatientAddresses", t => t.AddressId, cascadeDelete: true)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.PatientAddresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        AddressLine3 = c.String(),
                        Patient_PId = c.Int(),
                        Patient_PId1 = c.Int(),
                    })
                .PrimaryKey(t => t.AddressId)
                .Index(t => t.Patient_PId)
                .Index(t => t.Patient_PId1);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.PatientAddresses", new[] { "Patient_PId1" });
            DropIndex("dbo.PatientAddresses", new[] { "Patient_PId" });
            DropIndex("dbo.Patients", new[] { "AddressId" });
            DropIndex("dbo.Subjects", new[] { "student_StudentId" });
            DropForeignKey("dbo.PatientAddresses", "Patient_PId1", "dbo.Patients");
            DropForeignKey("dbo.PatientAddresses", "Patient_PId", "dbo.Patients");
            DropForeignKey("dbo.Patients", "AddressId", "dbo.PatientAddresses");
            DropForeignKey("dbo.Subjects", "student_StudentId", "dbo.students");
            DropTable("dbo.PatientAddresses");
            DropTable("dbo.Patients");
            DropTable("dbo.faculties");
            DropTable("dbo.Subjects");
            DropTable("dbo.students");
        }
    }
}
