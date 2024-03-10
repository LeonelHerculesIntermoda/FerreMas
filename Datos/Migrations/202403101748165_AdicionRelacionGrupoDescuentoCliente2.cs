namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionRelacionGrupoDescuentoCliente2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Cliente", "GrupoDescuentoClienteId");
            AddForeignKey("dbo.Cliente", "GrupoDescuentoClienteId", "dbo.GrupoDescuentoCliente", "GrupoDescuentoClienteId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cliente", "GrupoDescuentoClienteId", "dbo.GrupoDescuentoCliente");
            DropIndex("dbo.Cliente", new[] { "GrupoDescuentoClienteId" });
        }
    }
}
