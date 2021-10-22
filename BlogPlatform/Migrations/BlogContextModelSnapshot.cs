﻿// <auto-generated />
using System;
using BlogPlatform;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogPlatform.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogPlatform.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Video Games"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Basketball"
                        },
                        new
                        {
                            Id = 3,
                            Name = "GPUs"
                        });
                });

            modelBuilder.Entity("BlogPlatform.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Bona",
                            Body = "Random words",
                            CategoryId = 1,
                            PublishDate = new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Zelda is a wonderful game"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Bona",
                            Body = "Random words Random words",
                            CategoryId = 2,
                            PublishDate = new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Lebron James scored 50 in a loss to the Nets"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Bona",
                            Body = "Random words Random words Random words",
                            CategoryId = 3,
                            PublishDate = new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "3080 is still overpiced."
                        });
                });

            modelBuilder.Entity("BlogPlatform.Models.Content", b =>
                {
                    b.HasOne("BlogPlatform.Models.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlogPlatform.Models.Category", b =>
                {
                    b.Navigation("Blogs");
                });
#pragma warning restore 612, 618
        }
    }
}
