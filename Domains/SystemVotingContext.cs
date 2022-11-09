using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Domains;

public partial class SystemVotingContext :DbContext
{
    public SystemVotingContext()
    {
    }  

    public virtual DbSet<TbClub> TbClubs { get; set; }

    public virtual DbSet<TbCoch> TbCochs { get; set; }

    public virtual DbSet<TbGk> TbGks { get; set; }

    public virtual DbSet<TbImg> TbImgs { get; set; }

    public virtual DbSet<TbPlayer> TbPlayers { get; set; }

    public virtual DbSet<TbVoteOption> TbVoteOptions { get; set; }
    public virtual DbSet<TbUsers> TbUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-IIL7N6G;Database=SystemVoting;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        
        modelBuilder.Entity<TbClub>(entity =>
        {
            entity.HasKey(e => e.Clubid);
            entity.Property(e => e.Clubid).HasColumnName("clubid");
            entity.Property(e => e.Clubname)
                .HasMaxLength(50)
                .HasColumnName("clubname");
        });

        modelBuilder.Entity<TbCoch>(entity =>
        {
            entity.HasKey(e => e.Cochid);

            entity.Property(e => e.Cochid).HasColumnName("cochid");
            entity.Property(e => e.Cochname)
                .HasMaxLength(50)
                .HasColumnName("cochname");
        });

        modelBuilder.Entity<TbGk>(entity =>
        {
            entity.HasKey(e => e.Gkid);

            entity.Property(e => e.Gkid).HasColumnName("gkid");
            entity.Property(e => e.Gkname)
                .HasMaxLength(50)
                .HasColumnName("gkname");
        });

        modelBuilder.Entity<TbImg>(entity =>
        {
            entity.HasKey(e => e.Imgid);

            entity.Property(e => e.Imgid).HasColumnName("imgid");
            entity.Property(e => e.Imgname)
                .HasMaxLength(50)
                .HasColumnName("imgname");
        });

        modelBuilder.Entity<TbPlayer>(entity =>
        {
            entity.HasKey(e => e.Playerid);

            entity.Property(e => e.Playerid).HasColumnName("playerid");
            entity.Property(e => e.Playername)
                .HasMaxLength(50)
                .HasColumnName("playername");
        });

        modelBuilder.Entity<TbVoteOption>(entity =>
        {
           

            entity.Property(e => e.Clubid).HasColumnName("clubid");
            entity.Property(e => e.Cochid).HasColumnName("cochid");
            entity.Property(e => e.Gkid).HasColumnName("gkid");
            entity.Property(e => e.Playerid)
                .ValueGeneratedOnAdd()
                .HasColumnName("playerid");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(a => a.player).WithMany(A => A.VoteOptions).HasForeignKey(a => a.Playerid);
            entity.HasOne(a => a.coch).WithMany(A => A.VoteOptions).HasForeignKey(a => a.Cochid);
            entity.HasOne(a => a.club).WithMany(A => A.VoteOptions).HasForeignKey(a => a.Clubid);
            entity.HasOne(a => a.gk).WithMany(A => A.VoteOptions).HasForeignKey(a => a.Gkid);
            
        });
        
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
