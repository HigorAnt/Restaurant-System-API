﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurant.API.DbContexts;

#nullable disable

namespace Restaurant.API.Migrations
{
    [DbContext(typeof(SnackDbContext))]
    [Migration("20240620173249_Identity")]
    partial class Identity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("IngredientsSnack", b =>
                {
                    b.Property<int>("IngredientesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SnacksId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IngredientesId", "SnacksId");

                    b.HasIndex("SnacksId");

                    b.ToTable("IngredientsSnack");

                    b.HasData(
                        new
                        {
                            IngredientesId = 1,
                            SnacksId = 1
                        },
                        new
                        {
                            IngredientesId = 2,
                            SnacksId = 1
                        },
                        new
                        {
                            IngredientesId = 3,
                            SnacksId = 1
                        },
                        new
                        {
                            IngredientesId = 4,
                            SnacksId = 1
                        },
                        new
                        {
                            IngredientesId = 5,
                            SnacksId = 1
                        },
                        new
                        {
                            IngredientesId = 6,
                            SnacksId = 1
                        },
                        new
                        {
                            IngredientesId = 7,
                            SnacksId = 1
                        },
                        new
                        {
                            IngredientesId = 8,
                            SnacksId = 1
                        },
                        new
                        {
                            IngredientesId = 14,
                            SnacksId = 1
                        },
                        new
                        {
                            IngredientesId = 9,
                            SnacksId = 2
                        },
                        new
                        {
                            IngredientesId = 19,
                            SnacksId = 2
                        },
                        new
                        {
                            IngredientesId = 11,
                            SnacksId = 2
                        },
                        new
                        {
                            IngredientesId = 12,
                            SnacksId = 2
                        },
                        new
                        {
                            IngredientesId = 13,
                            SnacksId = 2
                        },
                        new
                        {
                            IngredientesId = 2,
                            SnacksId = 2
                        },
                        new
                        {
                            IngredientesId = 21,
                            SnacksId = 2
                        },
                        new
                        {
                            IngredientesId = 8,
                            SnacksId = 2
                        },
                        new
                        {
                            IngredientesId = 1,
                            SnacksId = 3
                        },
                        new
                        {
                            IngredientesId = 12,
                            SnacksId = 3
                        },
                        new
                        {
                            IngredientesId = 17,
                            SnacksId = 3
                        },
                        new
                        {
                            IngredientesId = 14,
                            SnacksId = 3
                        },
                        new
                        {
                            IngredientesId = 2,
                            SnacksId = 3
                        },
                        new
                        {
                            IngredientesId = 16,
                            SnacksId = 3
                        },
                        new
                        {
                            IngredientesId = 23,
                            SnacksId = 3
                        },
                        new
                        {
                            IngredientesId = 8,
                            SnacksId = 3
                        },
                        new
                        {
                            IngredientesId = 1,
                            SnacksId = 4
                        },
                        new
                        {
                            IngredientesId = 18,
                            SnacksId = 4
                        },
                        new
                        {
                            IngredientesId = 16,
                            SnacksId = 4
                        },
                        new
                        {
                            IngredientesId = 20,
                            SnacksId = 4
                        },
                        new
                        {
                            IngredientesId = 22,
                            SnacksId = 4
                        },
                        new
                        {
                            IngredientesId = 2,
                            SnacksId = 4
                        },
                        new
                        {
                            IngredientesId = 21,
                            SnacksId = 4
                        },
                        new
                        {
                            IngredientesId = 8,
                            SnacksId = 4
                        },
                        new
                        {
                            IngredientesId = 24,
                            SnacksId = 5
                        },
                        new
                        {
                            IngredientesId = 10,
                            SnacksId = 5
                        },
                        new
                        {
                            IngredientesId = 23,
                            SnacksId = 5
                        },
                        new
                        {
                            IngredientesId = 2,
                            SnacksId = 5
                        },
                        new
                        {
                            IngredientesId = 12,
                            SnacksId = 5
                        },
                        new
                        {
                            IngredientesId = 18,
                            SnacksId = 5
                        },
                        new
                        {
                            IngredientesId = 14,
                            SnacksId = 5
                        },
                        new
                        {
                            IngredientesId = 20,
                            SnacksId = 5
                        },
                        new
                        {
                            IngredientesId = 13,
                            SnacksId = 5
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Restaurant.API.Entities.Ingredients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Ingredientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Carne de Vaca"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cebola"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cerveja Escura"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Fatia de Pão Integral"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Mostarda"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Chicória"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Maionese"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Vários Temperos"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Mexilhões"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Aipo"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Batatas Fritas"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Tomate"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Extrato de Tomate"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Folha de Louro"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Cenoura"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Alho"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Vinho Tinto"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Leite de Coco"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Gengibre"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Pimenta Malagueta"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Tamarindo"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Peixe Firme"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Pasta de Gengibre e Alho"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Garam Masala"
                        });
                });

            modelBuilder.Entity("Restaurant.API.Entities.Snack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Snacks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ensopado Flamengo de Carne de Vaca com Chicória"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mexilhões com Batatas Fritas"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ragu alla Bolognese"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Rendang"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Masala de Peixe"
                        });
                });

            modelBuilder.Entity("IngredientsSnack", b =>
                {
                    b.HasOne("Restaurant.API.Entities.Ingredients", null)
                        .WithMany()
                        .HasForeignKey("IngredientesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restaurant.API.Entities.Snack", null)
                        .WithMany()
                        .HasForeignKey("SnacksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
