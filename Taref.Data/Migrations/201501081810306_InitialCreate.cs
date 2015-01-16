namespace Taref.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descrição = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Tarefa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descrição = c.String(maxLength: 30),
                        Prioridade = c.Int(nullable: false),
                        Titulo = c.String(nullable: false, maxLength: 10),
                        Categoria_Id = c.Int(nullable: false),
                        Responsavel_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categoria", t => t.Categoria_Id, cascadeDelete: true)
                .ForeignKey("dbo.Usuario", t => t.Responsavel_Id, cascadeDelete: true)
                .Index(t => t.Categoria_Id)
                .Index(t => t.Responsavel_Id);

            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 10),
                        Nome = c.String(nullable: false, maxLength: 180),
                        Senha = c.String(nullable: false, maxLength: 8),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Tarefa", "Responsavel_Id", "dbo.Usuario");
            DropForeignKey("dbo.Tarefa", "Categoria_Id", "dbo.Categoria");
            DropIndex("dbo.Tarefa", new[] { "Responsavel_Id" });
            DropIndex("dbo.Tarefa", new[] { "Categoria_Id" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Tarefa");
            DropTable("dbo.Categoria");
        }
    }
}