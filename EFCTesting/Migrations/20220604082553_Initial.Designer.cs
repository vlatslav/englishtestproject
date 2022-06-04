﻿// <auto-generated />
using System;
using EFCTesting.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCTesting.Migrations
{
    [DbContext(typeof(EnglishContext))]
    [Migration("20220604082553_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCTesting.DataModels.Answer", b =>
                {
                    b.Property<int>("AnswerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answ")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<bool>("Correct")
                        .HasColumnType("bit");

                    b.Property<int?>("QuestionID")
                        .HasColumnType("int");

                    b.HasKey("AnswerID");

                    b.HasIndex("QuestionID");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("EFCTesting.DataModels.Question", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Quest")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("TestID")
                        .HasColumnType("int");

                    b.HasKey("QuestionID");

                    b.HasIndex("TestID");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("EFCTesting.DataModels.Test", b =>
                {
                    b.Property<int>("TestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Done")
                        .HasColumnType("bit");

                    b.Property<string>("Progress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestID");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("EFCTesting.DataModels.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TestUser", b =>
                {
                    b.Property<int>("TestsTestID")
                        .HasColumnType("int");

                    b.Property<int>("UsersUserID")
                        .HasColumnType("int");

                    b.HasKey("TestsTestID", "UsersUserID");

                    b.HasIndex("UsersUserID");

                    b.ToTable("TestUser");
                });

            modelBuilder.Entity("EFCTesting.DataModels.Answer", b =>
                {
                    b.HasOne("EFCTesting.DataModels.Question", null)
                        .WithMany("Answer")
                        .HasForeignKey("QuestionID");
                });

            modelBuilder.Entity("EFCTesting.DataModels.Question", b =>
                {
                    b.HasOne("EFCTesting.DataModels.Test", null)
                        .WithMany("Questions")
                        .HasForeignKey("TestID");
                });

            modelBuilder.Entity("TestUser", b =>
                {
                    b.HasOne("EFCTesting.DataModels.Test", null)
                        .WithMany()
                        .HasForeignKey("TestsTestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCTesting.DataModels.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCTesting.DataModels.Question", b =>
                {
                    b.Navigation("Answer");
                });

            modelBuilder.Entity("EFCTesting.DataModels.Test", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
