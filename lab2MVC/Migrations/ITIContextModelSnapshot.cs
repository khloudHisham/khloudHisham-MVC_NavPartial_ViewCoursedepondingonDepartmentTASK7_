﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lab2MVC.Models;

#nullable disable

namespace lab2MVC.Migrations
{
    [DbContext(typeof(ITIContext))]
    partial class ITIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("lab2MVC.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("MinDegree")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Degree = 100,
                            DepartmentId = 1,
                            MinDegree = 60,
                            Name = "C#"
                        },
                        new
                        {
                            Id = 2,
                            Degree = 100,
                            DepartmentId = 3,
                            MinDegree = 60,
                            Name = "GIS"
                        },
                        new
                        {
                            Id = 3,
                            Degree = 100,
                            DepartmentId = 2,
                            MinDegree = 60,
                            Name = "ML"
                        });
                });

            modelBuilder.Entity("lab2MVC.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ManagerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ManagerName = "Mazen",
                            Name = "CS"
                        },
                        new
                        {
                            Id = 2,
                            ManagerName = "Ali",
                            Name = "AI"
                        },
                        new
                        {
                            Id = 3,
                            ManagerName = "Noha",
                            Name = "IS"
                        });
                });

            modelBuilder.Entity("lab2MVC.Models.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("ImageURl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("grade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Trainee");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Tanan",
                            DepartmentId = 1,
                            ImageURl = "man3.jpg",
                            Name = "Ahmed",
                            grade = 4
                        },
                        new
                        {
                            Id = 2,
                            Address = "NewYourk",
                            DepartmentId = 2,
                            ImageURl = "girl1.jpg",
                            Name = "Hager",
                            grade = 5
                        },
                        new
                        {
                            Id = 3,
                            Address = "Turkia",
                            DepartmentId = 3,
                            ImageURl = "girl5.jpg",
                            Name = "Soha",
                            grade = 6
                        });
                });

            modelBuilder.Entity("lab2MVC.Models.crsResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("TraineeId")
                        .HasColumnType("int");

                    b.Property<int>("degree")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("TraineeId");

                    b.ToTable("crsResult");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            TraineeId = 1,
                            degree = 80
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 2,
                            TraineeId = 2,
                            degree = 50
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 3,
                            TraineeId = 3,
                            degree = 100
                        });
                });

            modelBuilder.Entity("lab2MVC.Models.instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("ImageURl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("instructor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Cairo",
                            CourseId = 1,
                            DepartmentId = 1,
                            ImageURl = "man4.jpg",
                            Name = "Tamer",
                            Salary = 15000
                        },
                        new
                        {
                            Id = 2,
                            Address = "Giza",
                            CourseId = 3,
                            DepartmentId = 2,
                            ImageURl = "girl2.jpg",
                            Name = "Jasmen",
                            Salary = 20000
                        },
                        new
                        {
                            Id = 3,
                            Address = "Alex",
                            CourseId = 2,
                            DepartmentId = 1,
                            ImageURl = "girl4.jpg",
                            Name = "Sama",
                            Salary = 4000
                        },
                        new
                        {
                            Id = 4,
                            Address = "Koria",
                            CourseId = 1,
                            DepartmentId = 3,
                            ImageURl = "girl3.jpg",
                            Name = "Maha",
                            Salary = 8000
                        });
                });

            modelBuilder.Entity("lab2MVC.Models.Course", b =>
                {
                    b.HasOne("lab2MVC.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("lab2MVC.Models.Trainee", b =>
                {
                    b.HasOne("lab2MVC.Models.Department", "Department")
                        .WithMany("Trainees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("lab2MVC.Models.crsResult", b =>
                {
                    b.HasOne("lab2MVC.Models.Course", "Course")
                        .WithMany("crsResults")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("lab2MVC.Models.Trainee", "Trainee")
                        .WithMany("CrsResults")
                        .HasForeignKey("TraineeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("lab2MVC.Models.instructor", b =>
                {
                    b.HasOne("lab2MVC.Models.Course", "Course")
                        .WithMany("Instructors")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("lab2MVC.Models.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("lab2MVC.Models.Course", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("crsResults");
                });

            modelBuilder.Entity("lab2MVC.Models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Instructors");

                    b.Navigation("Trainees");
                });

            modelBuilder.Entity("lab2MVC.Models.Trainee", b =>
                {
                    b.Navigation("CrsResults");
                });
#pragma warning restore 612, 618
        }
    }
}
