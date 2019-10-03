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
                        id = c.Int(nullable: false, identity: true),
                        Author = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.testimonials");
        }
    }
}
