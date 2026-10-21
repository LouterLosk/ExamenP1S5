namespace Alcatraz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Eventoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false),
                        genero = c.String(nullable: false),
                        fecha = c.DateTime(nullable: false),
                        aforo = c.Int(nullable: false),
                        Evento_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Eventoes", t => t.Evento_Id)
                .Index(t => t.Evento_Id);
            
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreCliente = c.String(nullable: false),
                        TipoMesa = c.String(nullable: false),
                        NumeroPersonas = c.Int(nullable: false),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EventoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Eventoes", "Evento_Id", "dbo.Eventoes");
            DropIndex("dbo.Eventoes", new[] { "Evento_Id" });
            DropTable("dbo.Reservas");
            DropTable("dbo.Eventoes");
        }
    }
}
