﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StackOverFlow.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TempStackOverFlowEntities : DbContext
    {
        public TempStackOverFlowEntities()
            : base("name=TempStackOverFlowEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
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
        public virtual DbSet<WhereUserLikeToWork> WhereUserLikeToWorks { get; set; }
        public virtual DbSet<WorkExperience> WorkExperiences { get; set; }
    }
}
