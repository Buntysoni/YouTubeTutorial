using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace YouTubeTutorial.Data.context
{
    public class tbl_student
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int studentid { get; set; }
        public string? name { get; set; }
        public int subjectid { get; set; }
        [ForeignKey("subjectid")]
        public tbl_subject? tbl_subject { get; set; }
    }
    public class tbl_subject
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int subjectid { get; set; }
        public string? subjectname { get; set; }
    }

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<student> student { get; set; }
        public DbSet<addresses> addresses { get; set; }
        public DbSet<vehicle> vehicle { get; set; }
        public DbSet<tbl_student> tbl_student { get; set; }
        public DbSet<tbl_subject> tbl_subject { get; set; }
    }
}
