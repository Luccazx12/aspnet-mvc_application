namespace Tarefa3_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Curso_Sobrenome : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Curso", "Sobrenome", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Curso", "Sobrenome");
        }
    }
}
