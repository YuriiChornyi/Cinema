namespace Cinema
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Cinema_data")
        {
        }

        public virtual DbSet<Cinema> Cinema { get; set; }
        public virtual DbSet<Cinema_Session> Cinema_Session { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Hall> Hall { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<Session> Session { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Session>()
                .HasMany(e => e.Cinema_Session)
                .WithRequired(e => e.Session)
                .HasForeignKey(e => e.Cinema_Id);
        }
    }
}
