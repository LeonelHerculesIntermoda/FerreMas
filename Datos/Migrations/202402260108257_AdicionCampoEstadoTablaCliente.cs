namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionCampoEstadoTablaCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "Estado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cliente", "Estado");
        }
    }
}
