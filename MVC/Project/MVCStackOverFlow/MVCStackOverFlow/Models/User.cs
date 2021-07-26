namespace MVCStackOverFlow.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Answers = new HashSet<Answer>();
            BadgesEarnedByUsers = new HashSet<BadgesEarnedByUser>();
            Bookmarks = new HashSet<Bookmark>();
            CompaniesToExcludes = new HashSet<CompaniesToExclude>();
            Educations = new HashSet<Education>();
            IndustriesToExcludes = new HashSet<IndustriesToExclude>();
            JobProfiles = new HashSet<JobProfile>();
            Questions = new HashSet<Question>();
            TechnologiesUsedAsStudents = new HashSet<TechnologiesUsedAsStudent>();
            TechnologiesUsedByUserInJobs = new HashSet<TechnologiesUsedByUserInJob>();
            TechPreferNotToWorkWiths = new HashSet<TechPreferNotToWorkWith>();
            TechWantToWorkWiths = new HashSet<TechWantToWorkWith>();
            WhereUserLikeToWorks = new HashSet<WhereUserLikeToWork>();
            WorkExperiences = new HashSet<WorkExperience>();
        }

        public int UserID { get; set; }

        [Required]
        [StringLength(25)]
        public string UserName { get; set; }

        [Required]
        [StringLength(30)]
        public string FullName { get; set; }

        public int UserRoleId { get;set; }

        [StringLength(20)]
        public string Title { get; set; }

        public int? VisitedDays { get; set; }

        [StringLength(100)]
        public string GitHub { get; set; }

        [StringLength(100)]
        public string Twitter { get; set; }

        public int? Reputaion { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        public DateTime? LastSeen { get; set; }

        public int? ProfileViews { get; set; }

        [StringLength(200)]
        public string AboutUser { get; set; }

        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailID { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        public string HashPassword { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answer> Answers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BadgesEarnedByUser> BadgesEarnedByUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bookmark> Bookmarks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompaniesToExclude> CompaniesToExcludes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Education> Educations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndustriesToExclude> IndustriesToExcludes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobProfile> JobProfiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TechnologiesUsedAsStudent> TechnologiesUsedAsStudents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TechnologiesUsedByUserInJob> TechnologiesUsedByUserInJobs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TechPreferNotToWorkWith> TechPreferNotToWorkWiths { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TechWantToWorkWith> TechWantToWorkWiths { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WhereUserLikeToWork> WhereUserLikeToWorks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkExperience> WorkExperiences { get; set; }

        public virtual UserRole UserRole { get; set; }
    }
}
