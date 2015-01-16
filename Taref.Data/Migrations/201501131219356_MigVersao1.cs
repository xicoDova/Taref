namespace Taref.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class MigVersao1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tarefa", "Situação", c => c.Int(nullable: false));
            AddColumn("dbo.Tarefa", "Inicio", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tarefa", "Termino", c => c.DateTime(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Tarefa", "Termino");
            DropColumn("dbo.Tarefa", "Inicio");
            DropColumn("dbo.Tarefa", "Situação");
        }
    }
}