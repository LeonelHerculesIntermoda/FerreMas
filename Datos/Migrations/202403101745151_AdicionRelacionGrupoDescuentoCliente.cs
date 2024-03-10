namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionRelacionGrupoDescuentoCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "GrupoDescuentoClienteId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cliente", "GrupoDescuentoClienteId");
        }
    }
}
