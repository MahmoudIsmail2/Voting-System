﻿// <auto-generated />
using Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Domains.Migrations
{
    [DbContext(typeof(SystemVotingContext))]
    [Migration("20221107092127_vv")]
    partial class vv
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc.2.22472.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domains.TbClub", b =>
                {
                    b.Property<int>("Clubid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("clubid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Clubid"));

                    b.Property<string>("Clubname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("clubname");

                    b.HasKey("Clubid");

                    b.ToTable("TbClubs");
                });

            modelBuilder.Entity("Domains.TbCoch", b =>
                {
                    b.Property<int>("Cochid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cochid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cochid"));

                    b.Property<string>("Cochname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("cochname");

                    b.HasKey("Cochid");

                    b.ToTable("TbCochs");
                });

            modelBuilder.Entity("Domains.TbGk", b =>
                {
                    b.Property<int>("Gkid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("gkid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Gkid"));

                    b.Property<string>("Gkname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("gkname");

                    b.HasKey("Gkid");

                    b.ToTable("TbGks");
                });

            modelBuilder.Entity("Domains.TbImg", b =>
                {
                    b.Property<int>("Imgid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("imgid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Imgid"));

                    b.Property<string>("Imgname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("imgname");

                    b.HasKey("Imgid");

                    b.ToTable("TbImgs");
                });

            modelBuilder.Entity("Domains.TbPlayer", b =>
                {
                    b.Property<int>("Playerid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("playerid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Playerid"));

                    b.Property<string>("Playername")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("playername");

                    b.HasKey("Playerid");

                    b.ToTable("TbPlayers");
                });

            modelBuilder.Entity("Domains.TbUsers", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int>("UserAge")
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserExperience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserJob")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("TbUsers");
                });

            modelBuilder.Entity("Domains.TbVoteOption", b =>
                {
                    b.Property<int>("voteid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("voteid"));

                    b.Property<int>("Clubid")
                        .HasColumnType("int")
                        .HasColumnName("clubid");

                    b.Property<int>("Cochid")
                        .HasColumnType("int")
                        .HasColumnName("cochid");

                    b.Property<int>("Gkid")
                        .HasColumnType("int")
                        .HasColumnName("gkid");

                    b.Property<int>("Playerid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("playerid");

                    b.Property<string>("Userid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("userid");

                    b.HasKey("voteid");

                    b.HasIndex("Clubid");

                    b.HasIndex("Cochid");

                    b.HasIndex("Gkid");

                    b.HasIndex("Playerid");

                    b.ToTable("TbVoteOptions");
                });

            modelBuilder.Entity("Domains.TbVoteOption", b =>
                {
                    b.HasOne("Domains.TbClub", "club")
                        .WithMany("VoteOptions")
                        .HasForeignKey("Clubid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domains.TbCoch", "coch")
                        .WithMany("VoteOptions")
                        .HasForeignKey("Cochid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domains.TbGk", "gk")
                        .WithMany("VoteOptions")
                        .HasForeignKey("Gkid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domains.TbPlayer", "player")
                        .WithMany("VoteOptions")
                        .HasForeignKey("Playerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("club");

                    b.Navigation("coch");

                    b.Navigation("gk");

                    b.Navigation("player");
                });

            modelBuilder.Entity("Domains.TbClub", b =>
                {
                    b.Navigation("VoteOptions");
                });

            modelBuilder.Entity("Domains.TbCoch", b =>
                {
                    b.Navigation("VoteOptions");
                });

            modelBuilder.Entity("Domains.TbGk", b =>
                {
                    b.Navigation("VoteOptions");
                });

            modelBuilder.Entity("Domains.TbPlayer", b =>
                {
                    b.Navigation("VoteOptions");
                });
#pragma warning restore 612, 618
        }
    }
}
