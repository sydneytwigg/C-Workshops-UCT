namespace Jan_2019_Past_Paper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fine",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        LicensePlate = c.String(nullable: false, maxLength: 8),
                        VehicleType = c.Int(nullable: false),
                        Offense = c.Int(nullable: false),
                        OffenseDetail = c.String(),
                        OffenseDate = c.DateTime(nullable: false),
                        OffenseTime = c.DateTime(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Outstanding = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fine");
        }
    }
}
