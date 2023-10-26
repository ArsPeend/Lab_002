namespace Lab_002.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTripType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartureStation = c.String(),
                        ArrivalStation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trips");
        }
    }
}
