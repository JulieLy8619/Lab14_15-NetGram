﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetGram.Data;

namespace NetGram.Migrations
{
    [DbContext(typeof(NetGramDBContext))]
    [Migration("20190214190853_reviseddb")]
    partial class reviseddb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NetGram.Models.Post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("Description");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("PostsTable");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Author = "Bob Smith",
                            Description = "a really cool description",
                            ImageURL = "tempImage.jpg"
                        },
                        new
                        {
                            ID = 2,
                            Author = "Sally Smith",
                            Description = "a not cool description",
                            ImageURL = "tempImage2.jpg"
                        },
                        new
                        {
                            ID = 3,
                            Author = "John Smith",
                            Description = "a lame description",
                            ImageURL = "tempImage3.jpg"
                        },
                        new
                        {
                            ID = 4,
                            Author = "Jane Smith",
                            Description = "just a description",
                            ImageURL = "tempImage4.jpg"
                        },
                        new
                        {
                            ID = 5,
                            Author = "Billy Smith",
                            Description = "a secret description that if I tell you I have to k*** you ;)",
                            ImageURL = "tempImage5.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
