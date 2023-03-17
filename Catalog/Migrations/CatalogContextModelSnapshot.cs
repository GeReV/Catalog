﻿// <auto-generated />
using System;
using Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Catalog.Migrations
{
    [DbContext(typeof(CatalogContext))]
    partial class CatalogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("Catalog.Model.Developer", b =>
                {
                    b.Property<int>("DeveloperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATETIME('now')");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATETIME('now')");

                    b.Property<string>("Links")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("MobyGamesCompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DeveloperId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Developers");
                });

            modelBuilder.Entity("Catalog.Model.File", b =>
                {
                    b.Property<int>("FileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<int>("GameItemId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Sha256Checksum")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("FileId");

                    b.HasIndex("GameItemId");

                    b.ToTable("File");
                });

            modelBuilder.Entity("Catalog.Model.GameCopy", b =>
                {
                    b.Property<int>("GameCopyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CoverImage")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATETIME('now')");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATETIME('now')");

                    b.Property<string>("Links")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint?>("MobyGamesId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MobyGamesSlug")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Platforms")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PublisherId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Screenshots")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Sealed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TwoLetterIsoLanguageName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("GameCopyId");

                    b.HasIndex("MobyGamesId");

                    b.HasIndex("MobyGamesSlug");

                    b.HasIndex("PublisherId");

                    b.HasIndex("Title");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Catalog.Model.GameCopyDeveloper", b =>
                {
                    b.Property<int>("GameCopyId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DeveloperId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATETIME('now')");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATETIME('now')");

                    b.HasKey("GameCopyId", "DeveloperId");

                    b.HasIndex("DeveloperId");

                    b.ToTable("GameCopyDeveloper");
                });

            modelBuilder.Entity("Catalog.Model.GameCopyTag", b =>
                {
                    b.Property<int>("GameCopyId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATETIME('now')");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATETIME('now')");

                    b.HasKey("GameCopyId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("GameCopyTags");
                });

            modelBuilder.Entity("Catalog.Model.GameItem", b =>
                {
                    b.Property<int>("GameItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Condition")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConditionDetails")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATETIME('now')");

                    b.Property<int?>("GameCopyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATETIME('now')");

                    b.Property<bool>("Missing")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.HasKey("GameItemId");

                    b.HasIndex("GameCopyId");

                    b.ToTable("GameItem");
                });

            modelBuilder.Entity("Catalog.Model.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<int>("GameItemId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ImageId");

                    b.HasIndex("GameItemId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Catalog.Model.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATETIME('now')");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATETIME('now')");

                    b.Property<string>("Links")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("MobyGamesCompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PublisherId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("Catalog.Model.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ColorArgb")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATETIME('now')");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("DATETIME('now')");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TagId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Catalog.Model.File", b =>
                {
                    b.HasOne("Catalog.Model.GameItem", "GameItem")
                        .WithMany("Files")
                        .HasForeignKey("GameItemId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("GameItem");
                });

            modelBuilder.Entity("Catalog.Model.GameCopy", b =>
                {
                    b.HasOne("Catalog.Model.Publisher", "Publisher")
                        .WithMany("Games")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Catalog.Model.GameCopyDeveloper", b =>
                {
                    b.HasOne("Catalog.Model.Developer", "Developer")
                        .WithMany("GameCopyDevelopers")
                        .HasForeignKey("DeveloperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Catalog.Model.GameCopy", "Game")
                        .WithMany("GameCopyDevelopers")
                        .HasForeignKey("GameCopyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Developer");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("Catalog.Model.GameCopyTag", b =>
                {
                    b.HasOne("Catalog.Model.GameCopy", "Game")
                        .WithMany("GameCopyTags")
                        .HasForeignKey("GameCopyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Catalog.Model.Tag", "Tag")
                        .WithMany("GameCopyTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Catalog.Model.GameItem", b =>
                {
                    b.HasOne("Catalog.Model.GameCopy", "Game")
                        .WithMany("Items")
                        .HasForeignKey("GameCopyId");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("Catalog.Model.Image", b =>
                {
                    b.HasOne("Catalog.Model.GameItem", "GameItem")
                        .WithMany("Scans")
                        .HasForeignKey("GameItemId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("GameItem");
                });

            modelBuilder.Entity("Catalog.Model.Developer", b =>
                {
                    b.Navigation("GameCopyDevelopers");
                });

            modelBuilder.Entity("Catalog.Model.GameCopy", b =>
                {
                    b.Navigation("GameCopyDevelopers");

                    b.Navigation("GameCopyTags");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("Catalog.Model.GameItem", b =>
                {
                    b.Navigation("Files");

                    b.Navigation("Scans");
                });

            modelBuilder.Entity("Catalog.Model.Publisher", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("Catalog.Model.Tag", b =>
                {
                    b.Navigation("GameCopyTags");
                });
#pragma warning restore 612, 618
        }
    }
}
