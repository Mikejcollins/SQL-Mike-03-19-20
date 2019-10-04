namespace SQL_Mike_03_19_20.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testimonials : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.testimonials",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Author = c.String(),
                        Content = c.String(),
                        Added = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.testimonials");
        }
    }
}
