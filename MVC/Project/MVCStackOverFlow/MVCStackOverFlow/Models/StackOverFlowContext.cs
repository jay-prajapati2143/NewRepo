using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVCStackOverFlow.Models
{
    public partial class StackOverFlowContext : DbContext
    {
        public StackOverFlowContext()
            : base("name=StackOverFlowContext")
        {
        }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Badge> Badges { get; set; }
        public virtual DbSet<BadgesEarnedByUser> BadgesEarnedByUsers { get; set; }
        public virtual DbSet<Bookmark> Bookmarks { get; set; }
        public virtual DbSet<CompaniesToExclude> CompaniesToExcludes { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<IndustriesToExclude> IndustriesToExcludes { get; set; }
        public virtual DbSet<JobProfile> JobProfiles { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TechnologiesUsedAsStudent> TechnologiesUsedAsStudents { get; set; }
        public virtual DbSet<TechnologiesUsedByUserInJob> TechnologiesUsedByUserInJobs { get; set; }
        public virtual DbSet<TechPreferNotToWorkWith> TechPreferNotToWorkWiths { get; set; }
        public virtual DbSet<TechWantToWorkWith> TechWantToWorkWiths { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<WhereUserLikeToWork> WhereUserLikeToWorks { get; set; }
        public virtual DbSet<WorkExperience> WorkExperiences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>()
                .Property(e => e.AnswerBody)
                .IsUnicode(false);

            modelBuilder.Entity<Badge>()
                .Property(e => e.BadgeName)
                .IsUnicode(false);

            modelBuilder.Entity<Badge>()
                .Property(e => e.BadgeCategory)
                .IsUnicode(false);

            modelBuilder.Entity<Badge>()
                .Property(e => e.BadgeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Badge>()
                .Property(e => e.BadgeType)
                .IsUnicode(false);

            modelBuilder.Entity<CompaniesToExclude>()
                .Property(e => e.CompanyToExclude)
                .IsUnicode(false);

            modelBuilder.Entity<Education>()
                .Property(e => e.Degree)
                .IsUnicode(false);

            modelBuilder.Entity<Education>()
                .Property(e => e.University)
                .IsUnicode(false);

            modelBuilder.Entity<Education>()
                .Property(e => e.Summary)
                .IsUnicode(false);

            modelBuilder.Entity<IndustriesToExclude>()
                .Property(e => e.IndustryToExclude)
                .IsUnicode(false);

            modelBuilder.Entity<JobProfile>()
                .Property(e => e.JobType)
                .IsUnicode(false);

            modelBuilder.Entity<JobProfile>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<JobProfile>()
                .Property(e => e.JobSearchStatus)
                .IsUnicode(false);

            modelBuilder.Entity<JobProfile>()
                .Property(e => e.Industry)
                .IsUnicode(false);

            modelBuilder.Entity<JobProfile>()
                .Property(e => e.MinAnnualSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Question>()
                .Property(e => e.QuestionTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.QuestionBody)
                .IsUnicode(false);

            modelBuilder.Entity<TechnologiesUsedAsStudent>()
                .Property(e => e.Technology)
                .IsUnicode(false);

            modelBuilder.Entity<TechnologiesUsedByUserInJob>()
                .Property(e => e.Technologies)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);
                

            modelBuilder.Entity<User>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.GitHub)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Twitter)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.AboutUser)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.EmailID)
                .IsUnicode(false);

            modelBuilder.Entity<WhereUserLikeToWork>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<WorkExperience>()
                .Property(e => e.JobTitle)
                .IsUnicode(false);

            modelBuilder.Entity<WorkExperience>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<WorkExperience>()
                .Property(e => e.Responsibilities)
                .IsUnicode(false);
        }
    }
}
