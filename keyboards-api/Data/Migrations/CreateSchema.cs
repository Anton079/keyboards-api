using FluentMigrator;

namespace keyboards_api.Data.Migrations
{
    [Migration(02022025)]
    public class CreateSchema : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("keyboard")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("type").AsString(120).NotNullable()
                .WithColumn("model").AsString(120).NotNullable()
                .WithColumn("price").AsInt32().NotNullable();
        }
    }
}
