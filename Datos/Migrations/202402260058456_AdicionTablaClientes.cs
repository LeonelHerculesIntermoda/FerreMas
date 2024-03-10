namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionTablaClientes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 10),
                        DNI = c.String(nullable: false, maxLength: 25),
                        Nombres = c.String(nullable: false, maxLength: 80),
                        Apellidos = c.String(nullable: false, maxLength: 80),
                        FechaIngreso = c.DateTime(nullable: false),
                        CategoriaClienteId = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.CategoriaClientes", t => t.CategoriaClienteId)
                .Index(t => t.CategoriaClienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cliente", "CategoriaClienteId", "dbo.CategoriaClientes");
            DropIndex("dbo.Cliente", new[] { "CategoriaClienteId" });
            DropTable("dbo.Cliente");
        }
    }
}
