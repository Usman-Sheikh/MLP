namespace MLP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "CategoryCourses_CategoryCourseId", "dbo.CategoryCourses");
            DropIndex("dbo.Courses", new[] { "CategoryCourses_CategoryCourseId" });
            AddColumn("dbo.Courses", "CategoryCourses_CategoryCourseId1", c => c.Int());
            AlterColumn("dbo.Courses", "CategoryCourses_CategoryCourseId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "CategoryCourses_CategoryCourseId1");
            AddForeignKey("dbo.Courses", "CategoryCourses_CategoryCourseId1", "dbo.CategoryCourses", "CategoryCourseId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "CategoryCourses_CategoryCourseId1", "dbo.CategoryCourses");
            DropIndex("dbo.Courses", new[] { "CategoryCourses_CategoryCourseId1" });
            AlterColumn("dbo.Courses", "CategoryCourses_CategoryCourseId", c => c.Int());
            DropColumn("dbo.Courses", "CategoryCourses_CategoryCourseId1");
            CreateIndex("dbo.Courses", "CategoryCourses_CategoryCourseId");
            AddForeignKey("dbo.Courses", "CategoryCourses_CategoryCourseId", "dbo.CategoryCourses", "CategoryCourseId");
        }
    }
}
