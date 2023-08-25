namespace Vidly.Migrations
{
    using Microsoft.AspNet.Identity;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'820d9c0b-fdcf-46f8-b037-d2d6e9eeca95', N'admin@vidly.com', 0, N'AGnmw8zBehvZNtfi9rKdIbuFlYzthBfEkZr8NsfbXWcvaipixbIUzCX/XaGm2nEhjQ==', N'2c833b2f-f312-4059-b66f-ba37b24664ae', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'ecd76c45-c971-4a85-bad9-67963ef7c60c', N'guest@vidly.com', 0, N'AOOyEoOUbsENZOZPfSRY91NnQudiy1F7m5TM7aZJ+O9uF3ltjcZUk0kUhL24hNgcxQ==', N'4f607e61-df6e-4dc9-89b3-c2fee46b74e4', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a478d026-b442-4c61-9033-bec6c6797412', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'820d9c0b-fdcf-46f8-b037-d2d6e9eeca95', N'a478d026-b442-4c61-9033-bec6c6797412')


");         
        }

        public override void Down()
        {
        }
    }
}
