namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambiosFinales : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "FechaEliminacion", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cliente", "FechaEliminacion");
        }
    }
}
