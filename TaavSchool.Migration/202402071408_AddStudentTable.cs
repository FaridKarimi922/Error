using FluentMigrator;

namespace TaavSchool.Migrations 
{
    [Migration(202402071408)]
    public class _202402071408_AddStudentTable : Migration
    {

        public override void Up()
        {
            Create.Table("Students")
                .WithColumn("FirstName").AsString(50).NotNullable()
                .WithColumn("LastName").AsString(50).NotNullable()
                .WithColumn("Latitude").AsInt32().NotNullable()
                .WithColumn("Longitude").AsInt32().NotNullable()
                .WithColumn("FirstName").AsString(50).NotNullable();




        }
        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}
