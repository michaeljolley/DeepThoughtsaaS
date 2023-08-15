﻿// <auto-generated />
using DeepThoughtsaaS.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DeepThoughtsaaS.Core.Migrations
{
    [DbContext(typeof(ThoughtDbContext))]
    [Migration("20230815205228_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DeepThoughtsaaS.Core.Thought", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Downvotes")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Upvotes")
                        .HasColumnType("int");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Thoughts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Downvotes = 0,
                            Text = "If you go flying back through time, and you see somebody else flying forward into the future, it's probably best to avoid eye contact.",
                            Upvotes = 0,
                            Views = 0
                        },
                        new
                        {
                            Id = 2,
                            Downvotes = 0,
                            Text = "If I ever get real rich, I hope I'm not real mean to poor people, like I am now.",
                            Upvotes = 0,
                            Views = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
