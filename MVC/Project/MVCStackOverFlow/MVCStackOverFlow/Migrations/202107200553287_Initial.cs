namespace MVCStackOverFlow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
        //    CreateTable(
        //        "dbo.Answers",
        //        c => new
        //            {
        //                AnswerID = c.Int(nullable: false, identity: true),
        //                QuestionID = c.Int(),
        //                UserID = c.Int(),
        //                AnswerBody = c.String(unicode: false),
        //                Vote = c.Int(),
        //            })
        //        .PrimaryKey(t => t.AnswerID)
        //        .ForeignKey("dbo.Questions", t => t.QuestionID)
        //        .ForeignKey("dbo.Users", t => t.UserID)
        //        .Index(t => t.QuestionID)
        //        .Index(t => t.UserID);
            
        //    CreateTable(
        //        "dbo.Questions",
        //        c => new
        //            {
        //                QuestionID = c.Int(nullable: false, identity: true),
        //                UserID = c.Int(),
        //                QuestionTitle = c.String(maxLength: 500, unicode: false),
        //                QuestionBody = c.String(unicode: false),
        //                TotalViews = c.Int(),
        //                Vote = c.Int(),
        //                TimeOfAsk = c.DateTime(),
        //            })
        //        .PrimaryKey(t => t.QuestionID)
        //        .ForeignKey("dbo.Users", t => t.UserID)
        //        .Index(t => t.UserID);
            
        //    CreateTable(
        //        "dbo.Bookmarks",
        //        c => new
        //            {
        //                ID = c.Int(nullable: false, identity: true),
        //                UserID = c.Int(),
        //                QuestionID = c.Int(),
        //            })
        //        .PrimaryKey(t => t.ID)
        //        .ForeignKey("dbo.Questions", t => t.QuestionID)
        //        .ForeignKey("dbo.Users", t => t.UserID)
        //        .Index(t => t.UserID)
        //        .Index(t => t.QuestionID);
            
        //    CreateTable(
        //        "dbo.Users",
        //        c => new
        //            {
        //                UserID = c.Int(nullable: false, identity: true),
        //                UserName = c.String(nullable: false, maxLength: 25, unicode: false),
        //                FullName = c.String(nullable: false, maxLength: 30, unicode: false),
        //                Title = c.String(maxLength: 20, unicode: false),
        //                VisitedDays = c.Int(),
        //                GitHub = c.String(maxLength: 100, unicode: false),
        //                Twitter = c.String(maxLength: 100, unicode: false),
        //                Reputaion = c.Int(),
        //                Location = c.String(maxLength: 50, unicode: false),
        //                LastSeen = c.DateTime(),
        //                ProfileViews = c.Int(),
        //                AboutUser = c.String(maxLength: 200, unicode: false),
        //                PhoneNumber = c.String(maxLength: 10, unicode: false),
        //                EmailID = c.String(nullable: false, maxLength: 50, unicode: false),
        //            })
        //        .PrimaryKey(t => t.UserID);
            
        //    CreateTable(
        //        "dbo.BadgesEarnedByUser",
        //        c => new
        //            {
        //                ID = c.Int(nullable: false, identity: true),
        //                UserID = c.Int(),
        //                BadgeID = c.Int(),
        //                DateOfEarned = c.DateTime(storeType: "date"),
        //            })
        //        .PrimaryKey(t => t.ID)
        //        .ForeignKey("dbo.Badges", t => t.BadgeID)
        //        .ForeignKey("dbo.Users", t => t.UserID)
        //        .Index(t => t.UserID)
        //        .Index(t => t.BadgeID);
            
        //    CreateTable(
        //        "dbo.Badges",
        //        c => new
        //            {
        //                BadgeID = c.Int(nullable: false, identity: true),
        //                BadgeName = c.String(maxLength: 30, unicode: false),
        //                BadgeCategory = c.String(maxLength: 30, unicode: false),
        //                BadgeDescription = c.String(maxLength: 200, unicode: false),
        //                BadgeType = c.String(maxLength: 20, unicode: false),
        //            })
        //        .PrimaryKey(t => t.BadgeID);
            
        //    CreateTable(
        //        "dbo.CompaniesToExclude",
        //        c => new
        //            {
        //                ID = c.Int(nullable: false, identity: true),
        //                UserID = c.Int(),
        //                CompanyToExclude = c.String(maxLength: 30, unicode: false),
        //            })
        //        .PrimaryKey(t => t.ID)
        //        .ForeignKey("dbo.Users", t => t.UserID)
        //        .Index(t => t.UserID);
            
        //    CreateTable(
        //        "dbo.Education",
        //        c => new
        //            {
        //                ID = c.Int(nullable: false, identity: true),
        //                UserID = c.Int(),
        //                Degree = c.String(maxLength: 30, unicode: false),
        //                University = c.String(maxLength: 50, unicode: false),
        //                FromYear = c.Int(),
        //                ToYear = c.Int(),
        //                Summary = c.String(maxLength: 200, unicode: false),
        //            })
        //        .PrimaryKey(t => t.ID)
        //        .ForeignKey("dbo.Users", t => t.UserID)
        //        .Index(t => t.UserID);
            
        //    CreateTable(
        //        "dbo.IndustriesToExclude",
        //        c => new
        //            {
        //                ID = c.Int(nullable: false, identity: true),
        //                UserID = c.Int(),
        //                IndustryToExclude = c.String(maxLength: 30, unicode: false),
        //            })
        //        .PrimaryKey(t => t.ID)
        //        .ForeignKey("dbo.Users", t => t.UserID)
        //        .Index(t => t.UserID);
            
        //    CreateTable(
        //        "dbo.JobProfile",
        //        c => new
        //            {
        //                ID = c.Int(nullable: false, identity: true),
        //                UserID = c.Int(),
        //                JobType = c.String(maxLength: 30, unicode: false),
        //                Role = c.String(maxLength: 30, unicode: false),
        //                JobSearchStatus = c.String(maxLength: 50, unicode: false),
        //                Industry = c.String(maxLength: 30, unicode: false),
        //                MinAnnualSalary = c.Decimal(storeType: "money"),
        //                MinExperience = c.Int(),
        //                MaxExperience = c.Int(),
        //            })
        //        .PrimaryKey(t => t.ID)
        //        .ForeignKey("dbo.Users", t => t.UserID)
        //        .Index(t => t.UserID);
            
        //    CreateTable(
        //        "dbo.TechnologiesUsedAsStudent",
        //        c => new
        //            {
        //                ID = c.Int(nullable: false, identity: true),
        //                UserID = c.Int(),
        //                Technology = c.String(maxLength: 20, unicode: false),
        //            })
        //        .PrimaryKey(t => t.ID)
        //        .ForeignKey("dbo.Users", t => t.UserID)
        //        .Index(t => t.UserID);
            
        //    CreateTable(
        //        "dbo.TechnologiesUsedByUserInJob",
        //        c => new
        //            {
        //                ID = c.Int(nullable: false, identity: true),
        //                UserID = c.Int(),
        //                Technologies = c.String(maxLength: 20, unicode: false),
        //            })
        //        .PrimaryKey(t => t.ID)
        //        .ForeignKey("dbo.Users", t => t.UserID)
        //        .Index(t => t.UserID);
            
        //    CreateTable(
        //        "dbo.TechPreferNotToWorkWith",
        //        c => new
        //            {
        //                ID = c.Int(nullable: false, identity: true),
        //                UserID = c.Int(),
        //                TechPeferNotToWorkWith = c.String(maxLength: 30),
        //            })
        //        .PrimaryKey(t => t.ID)
        //        .ForeignKey("dbo.Users", t => t.UserID)
        //        .Index(t => t.UserID);
            
        //    CreateTable(
        //        "dbo.TechWantToWorkWith",
        //        c => new
        //            {
        //                ID = c.Int(nullable: false, identity: true),
        //                UserID = c.Int(),
        //                TechYouWantToWorkWith = c.String(maxLength: 30),
        //            })
        //        .PrimaryKey(t => t.ID)
        //        .ForeignKey("dbo.Users", t => t.UserID)
        //        .Index(t => t.UserID);
            
        //    CreateTable(
        //        "dbo.WhereUserLikeToWork",
        //        c => new
        //            {
        //                ID = c.Int(nullable: false, identity: true),
        //                UserID = c.Int(),
        //                Location = c.String(maxLength: 30, unicode: false),
        //            })
        //        .PrimaryKey(t => t.ID)
        //        .ForeignKey("dbo.Users", t => t.UserID)
        //        .Index(t => t.UserID);
            
        //    CreateTable(
        //        "dbo.WorkExperience",
        //        c => new
        //            {
        //                ID = c.Int(nullable: false, identity: true),
        //                UserID = c.Int(),
        //                JobTitle = c.String(maxLength: 30, unicode: false),
        //                CompanyName = c.String(maxLength: 30, unicode: false),
        //                YearOfJoinning = c.Int(),
        //                Responsibilities = c.String(maxLength: 200, unicode: false),
        //            })
        //        .PrimaryKey(t => t.ID)
        //        .ForeignKey("dbo.Users", t => t.UserID)
        //        .Index(t => t.UserID);
            
        //    CreateTable(
        //        "dbo.Tags",
        //        c => new
        //            {
        //                ID = c.Int(nullable: false, identity: true),
        //                QuestionID = c.Int(),
        //                TagName = c.String(maxLength: 30),
        //            })
        //        .PrimaryKey(t => t.ID)
        //        .ForeignKey("dbo.Questions", t => t.QuestionID)
        //        .Index(t => t.QuestionID);
            
        }
        
        public override void Down()
        {
        //    DropForeignKey("dbo.Tags", "QuestionID", "dbo.Questions");
        //    DropForeignKey("dbo.WorkExperience", "UserID", "dbo.Users");
        //    DropForeignKey("dbo.WhereUserLikeToWork", "UserID", "dbo.Users");
        //    DropForeignKey("dbo.TechWantToWorkWith", "UserID", "dbo.Users");
        //    DropForeignKey("dbo.TechPreferNotToWorkWith", "UserID", "dbo.Users");
        //    DropForeignKey("dbo.TechnologiesUsedByUserInJob", "UserID", "dbo.Users");
        //    DropForeignKey("dbo.TechnologiesUsedAsStudent", "UserID", "dbo.Users");
        //    DropForeignKey("dbo.Questions", "UserID", "dbo.Users");
        //    DropForeignKey("dbo.JobProfile", "UserID", "dbo.Users");
        //    DropForeignKey("dbo.IndustriesToExclude", "UserID", "dbo.Users");
        //    DropForeignKey("dbo.Education", "UserID", "dbo.Users");
        //    DropForeignKey("dbo.CompaniesToExclude", "UserID", "dbo.Users");
        //    DropForeignKey("dbo.Bookmarks", "UserID", "dbo.Users");
        //    DropForeignKey("dbo.BadgesEarnedByUser", "UserID", "dbo.Users");
        //    DropForeignKey("dbo.BadgesEarnedByUser", "BadgeID", "dbo.Badges");
        //    DropForeignKey("dbo.Answers", "UserID", "dbo.Users");
        //    DropForeignKey("dbo.Bookmarks", "QuestionID", "dbo.Questions");
        //    DropForeignKey("dbo.Answers", "QuestionID", "dbo.Questions");
        //    DropIndex("dbo.Tags", new[] { "QuestionID" });
        //    DropIndex("dbo.WorkExperience", new[] { "UserID" });
        //    DropIndex("dbo.WhereUserLikeToWork", new[] { "UserID" });
        //    DropIndex("dbo.TechWantToWorkWith", new[] { "UserID" });
        //    DropIndex("dbo.TechPreferNotToWorkWith", new[] { "UserID" });
        //    DropIndex("dbo.TechnologiesUsedByUserInJob", new[] { "UserID" });
        //    DropIndex("dbo.TechnologiesUsedAsStudent", new[] { "UserID" });
        //    DropIndex("dbo.JobProfile", new[] { "UserID" });
        //    DropIndex("dbo.IndustriesToExclude", new[] { "UserID" });
        //    DropIndex("dbo.Education", new[] { "UserID" });
        //    DropIndex("dbo.CompaniesToExclude", new[] { "UserID" });
        //    DropIndex("dbo.BadgesEarnedByUser", new[] { "BadgeID" });
        //    DropIndex("dbo.BadgesEarnedByUser", new[] { "UserID" });
        //    DropIndex("dbo.Bookmarks", new[] { "QuestionID" });
        //    DropIndex("dbo.Bookmarks", new[] { "UserID" });
        //    DropIndex("dbo.Questions", new[] { "UserID" });
        //    DropIndex("dbo.Answers", new[] { "UserID" });
        //    DropIndex("dbo.Answers", new[] { "QuestionID" });
        //    DropTable("dbo.Tags");
        //    DropTable("dbo.WorkExperience");
        //    DropTable("dbo.WhereUserLikeToWork");
        //    DropTable("dbo.TechWantToWorkWith");
        //    DropTable("dbo.TechPreferNotToWorkWith");
        //    DropTable("dbo.TechnologiesUsedByUserInJob");
        //    DropTable("dbo.TechnologiesUsedAsStudent");
        //    DropTable("dbo.JobProfile");
        //    DropTable("dbo.IndustriesToExclude");
        //    DropTable("dbo.Education");
        //    DropTable("dbo.CompaniesToExclude");
        //    DropTable("dbo.Badges");
        //    DropTable("dbo.BadgesEarnedByUser");
        //    DropTable("dbo.Users");
        //    DropTable("dbo.Bookmarks");
        //    DropTable("dbo.Questions");
        //    DropTable("dbo.Answers");
        }
    }
}
