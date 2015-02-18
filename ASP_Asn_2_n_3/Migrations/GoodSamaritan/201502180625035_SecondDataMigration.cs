namespace ASP_Asn_2_n_3.Migrations.GoodSamaritan
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondDataMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "Type", c => c.String());
            DropColumn("dbo.Services", "File");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "File", c => c.String());
            DropColumn("dbo.Services", "Type");
        }
    }
}
