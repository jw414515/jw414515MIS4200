namespace jw414515MIS4200.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseDetails",
                c => new
                    {
                        coursedetailID = c.Int(nullable: false, identity: true),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        courseID = c.Int(nullable: false),
                        instructorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.coursedetailID)
                .ForeignKey("dbo.Courses", t => t.courseID, cascadeDelete: true)
                .ForeignKey("dbo.Instructors", t => t.instructorID, cascadeDelete: true)
                .Index(t => t.courseID)
                .Index(t => t.instructorID);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        courseID = c.Int(nullable: false, identity: true),
                        description = c.String(),
                        courseStarted = c.DateTime(nullable: false),
                        studentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.courseID)
                .ForeignKey("dbo.Students", t => t.studentID, cascadeDelete: true)
                .Index(t => t.studentID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        studentID = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        email = c.String(),
                        studentSince = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.studentID);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        instructorID = c.Int(nullable: false, identity: true),
                        subject = c.String(),
                        salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.instructorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseDetails", "instructorID", "dbo.Instructors");
            DropForeignKey("dbo.Courses", "studentID", "dbo.Students");
            DropForeignKey("dbo.CourseDetails", "courseID", "dbo.Courses");
            DropIndex("dbo.Courses", new[] { "studentID" });
            DropIndex("dbo.CourseDetails", new[] { "instructorID" });
            DropIndex("dbo.CourseDetails", new[] { "courseID" });
            DropTable("dbo.Instructors");
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
            DropTable("dbo.CourseDetails");
        }
    }
}
