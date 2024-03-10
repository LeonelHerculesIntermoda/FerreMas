namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionTablaGrupoDescuentoCliente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GrupoDescuentoCliente",
                c => new
                    {
                        GrupoDescuentoClienteId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 10),
                        Descripcion = c.String(nullable: false, maxLength: 150),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GrupoDescuentoClienteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GrupoDescuentoCliente");
        }
    }
}
