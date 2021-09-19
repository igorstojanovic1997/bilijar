namespace bilijar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'12f4c6a8-2461-42cc-b8c9-fbac2a56c5b6', N'admin@bilijar.com', 0, N'AEdwZu142FCIoaWSbVe8Wm24Tqwdoj3y2dPSmw0zhMVCrS7lZBVlgo4WzJurMUbaXA==', N'38be5cff-ca85-4327-af57-ac1cee5d7d2d', NULL, 0, 0, NULL, 1, 0, N'admin@bilijar.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'37d1d513-d43b-42a4-8ae2-823e691dd38a', N'guest@bilijar.com', 0, N'ADDXslR8ge2csCoyuy3MOVa8aZI9VOI/wP9cQaqwjgzyDAZE9QdM4EdgSuK2ZtItKA==', N'06f48510-7e50-47d7-ae6b-fbed0204cf64', NULL, 0, 0, NULL, 1, 0, N'guest@bilijar.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5fb23f4b-4ec2-4438-8335-bec3b468afcd', N'CanManageReservations')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'12f4c6a8-2461-42cc-b8c9-fbac2a56c5b6', N'5fb23f4b-4ec2-4438-8335-bec3b468afcd')

");
        }
        
        public override void Down()
        {
        }
    }
}
