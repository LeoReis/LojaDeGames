namespace LojaDeGames.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'083f4da1-97ff-4285-ba29-8de9829b454c', N'admin@admin.com.br', 0, N'AKUleMiSnC0njNTuNNyMeUO6kYBa9YCE+wfuXLKC4HYKHc+fWNjUtrQdojeBozDmRg==', N'd41046f5-feed-4fdb-b23d-ff3c79b2a146', NULL, 0, 0, NULL, 1, 0, N'admin@admin.com.br')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e4f60411-cf74-4a32-af88-a336bbea6fd2', N'visitante@visitante.com.br', 0, N'AAq2SXTtWH8i/5uqEQ2t2mjYvQIG+tzp97DvYHfhLfEPQFW0V56tuuC5prICrNbjIg==', N'47055be0-d6ed-49b0-9724-fc0ad16402a0', NULL, 0, 0, NULL, 1, 0, N'visitante@visitante.com.br')
");
        }
        
        public override void Down()
        {
        }
    }
}
