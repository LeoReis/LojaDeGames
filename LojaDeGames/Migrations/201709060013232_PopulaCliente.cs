namespace LojaDeGames.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulaCliente : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Clientes (Nome,Cpf,Endereco) VALUES ('Leonardo Reis',123456879,'Jaraguá do Sul')");
            Sql("INSERT INTO Clientes (Nome,Cpf,Endereco) VALUES ('Lauro Reis',123456879,'Arroio do Sal')");
            Sql("INSERT INTO Clientes (Nome,Cpf,Endereco) VALUES ('Enedina Ribeiro',123456879,'Jaraguá do Sul')");
            Sql("INSERT INTO Clientes (Nome,Cpf,Endereco) VALUES ('Samuel Henrique',123456879,'Jaraguá do Sul')");
        }
        
        public override void Down()
        {
        }
    }
}
