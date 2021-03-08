﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NodaTime;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Schoodule.DataAccess;

namespace Schoodule.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "6.0.0-preview.1.21102.2")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("GroupEntityUserEntity", b =>
                {
                    b.Property<long>("GroupsId")
                        .HasColumnType("bigint");

                    b.Property<long>("UsersId")
                        .HasColumnType("bigint");

                    b.HasKey("GroupsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("GroupEntityUserEntity");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.ClassEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<long>("GroupId")
                        .HasColumnType("bigint")
                        .HasColumnName("group_id");

                    b.Property<long>("LessonId")
                        .HasColumnType("bigint")
                        .HasColumnName("lesson_id");

                    b.Property<long>("LessonTimeId")
                        .HasColumnType("bigint")
                        .HasColumnName("lesson_time_id");

                    b.Property<long>("LessonTypeId")
                        .HasColumnType("bigint")
                        .HasColumnName("lesson_type_id");

                    b.Property<long>("RoomId")
                        .HasColumnType("bigint")
                        .HasColumnName("room_id");

                    b.Property<long>("SchoolId")
                        .HasColumnType("bigint")
                        .HasColumnName("school_id");

                    b.Property<long>("TeacherId")
                        .HasColumnType("bigint")
                        .HasColumnName("teacher_id");

                    b.Property<int>("WeekType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0)
                        .HasColumnName("week_type");

                    b.Property<int>("Weekday")
                        .HasColumnType("integer")
                        .HasColumnName("weekday");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("LessonId");

                    b.HasIndex("LessonTimeId");

                    b.HasIndex("LessonTypeId");

                    b.HasIndex("RoomId");

                    b.HasIndex("SchoolId");

                    b.HasIndex("TeacherId");

                    b.ToTable("classes");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.GroupEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<long>("SchoolId")
                        .HasColumnType("bigint")
                        .HasColumnName("school_id");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId", "Name")
                        .IsUnique();

                    b.ToTable("groups");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.LessonEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<long>("SchoolId")
                        .HasColumnType("bigint")
                        .HasColumnName("group_id");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("lessons");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.LessonTimeEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("SchoolId")
                        .HasColumnType("bigint")
                        .HasColumnName("school_id");

                    b.Property<string>("Symbol")
                        .HasColumnType("text")
                        .HasColumnName("symbol");

                    b.Property<LocalTime>("Time")
                        .HasColumnType("time")
                        .HasColumnName("time");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("lesson_times");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.LessonTypeEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<long>("SchoolId")
                        .HasColumnType("bigint")
                        .HasColumnName("school_id");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("lesson_types");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.RoomEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<long>("SchoolId")
                        .HasColumnType("bigint")
                        .HasColumnName("school_id");

                    b.Property<string>("Uri")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)")
                        .HasColumnName("uri");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("rooms");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.SchoolEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("name");

                    b.Property<long>("SchoolTypeId")
                        .HasColumnType("bigint")
                        .HasColumnName("school_type_id");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("SchoolTypeId");

                    b.ToTable("schools");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.SchoolTypeEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("school_types");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.TeacherEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("email");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("firstname");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("lastname");

                    b.Property<string>("Patronymic")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("patronymic");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("phone");

                    b.Property<long>("SchoolId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("teachers");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.UserEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("GroupEntityUserEntity", b =>
                {
                    b.HasOne("Schoodule.DataAccess.Entities.GroupEntity", null)
                        .WithMany()
                        .HasForeignKey("GroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schoodule.DataAccess.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.ClassEntity", b =>
                {
                    b.HasOne("Schoodule.DataAccess.Entities.GroupEntity", "Group")
                        .WithMany("Classes")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schoodule.DataAccess.Entities.LessonEntity", "Lesson")
                        .WithMany("Classes")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schoodule.DataAccess.Entities.LessonTimeEntity", "LessonTime")
                        .WithMany("Classes")
                        .HasForeignKey("LessonTimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schoodule.DataAccess.Entities.LessonTypeEntity", "LessonType")
                        .WithMany("Classes")
                        .HasForeignKey("LessonTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schoodule.DataAccess.Entities.RoomEntity", "Room")
                        .WithMany("Classes")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schoodule.DataAccess.Entities.SchoolEntity", "School")
                        .WithMany("Classes")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schoodule.DataAccess.Entities.TeacherEntity", "Teacher")
                        .WithMany("Classes")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Lesson");

                    b.Navigation("LessonTime");

                    b.Navigation("LessonType");

                    b.Navigation("Room");

                    b.Navigation("School");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.GroupEntity", b =>
                {
                    b.HasOne("Schoodule.DataAccess.Entities.SchoolEntity", "School")
                        .WithMany("Groups")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.LessonEntity", b =>
                {
                    b.HasOne("Schoodule.DataAccess.Entities.SchoolEntity", "School")
                        .WithMany("Lessons")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.LessonTimeEntity", b =>
                {
                    b.HasOne("Schoodule.DataAccess.Entities.SchoolEntity", "School")
                        .WithMany("LessonTimes")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.LessonTypeEntity", b =>
                {
                    b.HasOne("Schoodule.DataAccess.Entities.SchoolEntity", "School")
                        .WithMany("LessonTypes")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.RoomEntity", b =>
                {
                    b.HasOne("Schoodule.DataAccess.Entities.SchoolEntity", "School")
                        .WithMany("Rooms")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.SchoolEntity", b =>
                {
                    b.HasOne("Schoodule.DataAccess.Entities.SchoolTypeEntity", "Type")
                        .WithMany("Schools")
                        .HasForeignKey("SchoolTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.TeacherEntity", b =>
                {
                    b.HasOne("Schoodule.DataAccess.Entities.SchoolEntity", "School")
                        .WithMany("Teachers")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.GroupEntity", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.LessonEntity", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.LessonTimeEntity", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.LessonTypeEntity", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.RoomEntity", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.SchoolEntity", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Groups");

                    b.Navigation("Lessons");

                    b.Navigation("LessonTimes");

                    b.Navigation("LessonTypes");

                    b.Navigation("Rooms");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.SchoolTypeEntity", b =>
                {
                    b.Navigation("Schools");
                });

            modelBuilder.Entity("Schoodule.DataAccess.Entities.TeacherEntity", b =>
                {
                    b.Navigation("Classes");
                });
#pragma warning restore 612, 618
        }
    }
}
