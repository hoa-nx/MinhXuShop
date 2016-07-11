namespace MinhXuShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddErrorTable_FixColumnMesaageName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Errors", "Message", c => c.String());
            DropColumn("dbo.Errors", "Messasge");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Errors", "Messasge", c => c.String());
            DropColumn("dbo.Errors", "Message");
        }
    }
}
