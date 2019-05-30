namespace MVCAuthNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_name_email : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "Name", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Contacts", "Phone", c => c.String(maxLength: 20));
            AlterColumn("dbo.Contacts", "Email", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Email", c => c.String());
            AlterColumn("dbo.Contacts", "Phone", c => c.String());
            AlterColumn("dbo.Contacts", "Name", c => c.String());
        }
    }
}
