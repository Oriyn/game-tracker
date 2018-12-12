namespace GameTracker
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GameTrackerDBmodel : DbContext
    {
        public GameTrackerDBmodel()
            : base("name=EntityDBmodel")
        {
        }

        public virtual DbSet<GAMEGENRE> GAMEGENREs { get; set; }
        public virtual DbSet<GAME> GAMES { get; set; }
        public virtual DbSet<SYSTEM> SYSTEMS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GAMEGENRE>()
                .Property(e => e.GENRENAME)
                .IsUnicode(false);

            modelBuilder.Entity<GAME>()
                .Property(e => e.GAMENAME)
                .IsUnicode(false);

            modelBuilder.Entity<GAME>()
                .Property(e => e.GAMEDESC)
                .IsUnicode(false);

            modelBuilder.Entity<GAME>()
                .HasMany(e => e.SYSTEMS)
                .WithMany(e => e.GAMES)
                .Map(m => m.ToTable("SYSGAMEINTER").MapLeftKey("GAMEID").MapRightKey("SYSID"));

            modelBuilder.Entity<SYSTEM>()
                .Property(e => e.SYSTEMNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYSTEM>()
                .Property(e => e.SYSMANUFACTURE)
                .IsUnicode(false);
        }
    }
}
