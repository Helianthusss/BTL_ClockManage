using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Vd_Bt
{
    public partial class StudentControlDB : DbContext
    {
        public StudentControlDB()
            : base("name=StudentControlDB")
        {
        }

        public virtual DbSet<Falculty> Falculties { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Falculty>()
                .Property(e => e.FacultyID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.FacultyID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .MapToStoredProcedures(e => e.Insert(i => i.HasName("AddStudent")));

            modelBuilder.Entity<Student>()
                .MapToStoredProcedures(e => e.Delete(i => i.HasName("DeleteStudent")));
        }
    }
}
