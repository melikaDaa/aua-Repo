﻿// <auto-generated />
using System;
using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AUA.ProjectName.DataLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.ActiveAccessToken", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("AccessToken")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("RefreshToken")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("RegistrationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(3)")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("ActiveAccessToken", "Acc");
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.AppUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Phone")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("RegistrationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(3)")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("AppUser", "Acc");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "Mr_lotfi@ymail.com",
                            FirstName = "Rahim",
                            IsActive = true,
                            LastName = "Lotfi",
                            Password = "3C9909AFEC25354D551DAE21590BB26E38D53F2173B8D3DC3EEE4C047E7AB1C1EB8B85103E3BE7BA613B31BB5C9C36214DC9F14A42FD7A2FDB84856BCA5C44C2",
                            Phone = "+989199906342",
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegistrationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(3)")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Role", "Acc");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatorUserId = 1L,
                            Description = "AUA default role",
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Admin"
                        });
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.UserAccess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccessCode")
                        .HasColumnType("int");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsIndirect")
                        .HasColumnType("bit");

                    b.Property<string>("PageDescription")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PageTitle")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistrationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(3)")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Title")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Url")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("UserAccess", "Acc");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessCode = 1,
                            CreatorUserId = 1L,
                            IsActive = true,
                            IsIndirect = true,
                            PageDescription = "User Management",
                            PageTitle = "User Management",
                            ParentId = 0,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "User Management",
                            Url = "../Accounting/AppUser"
                        },
                        new
                        {
                            Id = 2,
                            AccessCode = 3,
                            CreatorUserId = 1L,
                            IsActive = true,
                            IsIndirect = true,
                            PageDescription = "Access level management",
                            PageTitle = "Access level management",
                            ParentId = 0,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Access level management",
                            Url = "../Accounting/UserAccess"
                        },
                        new
                        {
                            Id = 3,
                            AccessCode = 2,
                            CreatorUserId = 1L,
                            IsActive = true,
                            IsIndirect = true,
                            PageDescription = "Role Management",
                            PageTitle = "Role Management",
                            ParentId = 0,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Role Management",
                            Url = "../Accounting/Role"
                        },
                        new
                        {
                            Id = 4,
                            AccessCode = 4,
                            CreatorUserId = 1L,
                            IsActive = true,
                            IsIndirect = true,
                            PageDescription = "Report access to users",
                            PageTitle = "Report access to users",
                            ParentId = 0,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Report access to users",
                            Url = "../reports/UserAccessReport"
                        },
                        new
                        {
                            Id = 5,
                            AccessCode = 5,
                            CreatorUserId = 1L,
                            IsActive = true,
                            IsIndirect = false,
                            PageDescription = "Reset Password",
                            PageTitle = "Reset User Password",
                            ParentId = 0,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Reset Password"
                        },
                        new
                        {
                            Id = 6,
                            AccessCode = 6,
                            CreatorUserId = 1L,
                            IsActive = true,
                            IsIndirect = true,
                            PageDescription = "Assign access to roles",
                            PageTitle = "Assign access to roles",
                            ParentId = 0,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "User Access Report"
                        });
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<long>("AppUserId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegistrationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(3)")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole", "Acc");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.UserRoleAccess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegistrationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(3)")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserAccessId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserAccessId");

                    b.ToTable("UserRoleAccess", "Acc");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 1,
                            UserAccessId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 1,
                            UserAccessId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 1,
                            UserAccessId = 3
                        },
                        new
                        {
                            Id = 4,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 1,
                            UserAccessId = 4
                        },
                        new
                        {
                            Id = 5,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 1,
                            UserAccessId = 5
                        },
                        new
                        {
                            Id = 6,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 1,
                            UserAccessId = 6
                        });
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.School.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("RegistrationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(3)")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.UserRole", b =>
                {
                    b.HasOne("AUA.ProjectName.DomainEntities.Entities.Accounting.AppUser", "AppUser")
                        .WithMany("UserRoles")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AUA.ProjectName.DomainEntities.Entities.Accounting.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.UserRoleAccess", b =>
                {
                    b.HasOne("AUA.ProjectName.DomainEntities.Entities.Accounting.Role", "Role")
                        .WithMany("UserRoleAccess")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AUA.ProjectName.DomainEntities.Entities.Accounting.UserAccess", "UserAccess")
                        .WithMany("RoleAccesses")
                        .HasForeignKey("UserAccessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("UserAccess");
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.AppUser", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.Role", b =>
                {
                    b.Navigation("UserRoleAccess");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.UserAccess", b =>
                {
                    b.Navigation("RoleAccesses");
                });
#pragma warning restore 612, 618
        }
    }
}
