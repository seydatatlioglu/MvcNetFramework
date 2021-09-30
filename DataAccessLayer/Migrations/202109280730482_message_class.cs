namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class message_class : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MesajID = c.Int(nullable: false, identity: true),
                        SenderMessage = c.String(),
                        ReceiverMail = c.String(),
                        Subject = c.String(),
                        MessageContent = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MesajID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}
