namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4fb865a9-4d5b-4c0b-ad79-d6a95a917b60', N'guest@vidly.com', 0, N'AKrhCh74d0v58RAhHwMJ1bpM8BKHNcnWvjc/y0Q6VMgBjZqdMdk+J3fIp6dI33qOfw==', N'9ffc35d3-feca-40fa-9845-9a4bcadc98cc', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fe4972a8-ea0b-4873-8e75-9556a8df6093', N'admin@vidly.com', 0, N'ANtXlK0Ba5pJ4gRAv7mEMm43kjx+umRqAF1F7bmSbBNU7WTiUhOtX3Gev+mHh7heEQ==', N'f53eb734-93da-430b-9658-4a566235f2db', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cb925cd3-2139-430b-b8d1-0277c8772c50', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fe4972a8-ea0b-4873-8e75-9556a8df6093', N'cb925cd3-2139-430b-b8d1-0277c8772c50')

               ");
        }
        
        public override void Down()
        {
        }
    }
}
