﻿// <auto-generated />
using System;
using CoffeeShop.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoffeeShop.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoffeeShop.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Smooth espresso with a generous layer of creamy milk foam, sprinkled with cocoa powder for a touch of indulgence.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Cappuccino",
                            Price = 2.5
                        },
                        new
                        {
                            Id = 2,
                            Description = "Delicate espresso combined with steamed milk, creating a smooth and balanced beverage, ideal for those who appreciate a mild and creamy coffee.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Latte",
                            Price = 3.0
                        },
                        new
                        {
                            Id = 3,
                            Description = "Strong and intense shot of espresso, perfect for those who crave a bold coffee flavor.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Espresso",
                            Price = 1.5
                        },
                        new
                        {
                            Id = 4,
                            Description = "Espresso diluted with hot water, resulting in a smooth and light coffee beverage.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Americano",
                            Price = 2.0
                        },
                        new
                        {
                            Id = 5,
                            Description = "Espresso with a small amount of steamed milk, providing a touch of smoothness and balance to the intense flavor of the coffee.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Macchiato",
                            Price = 2.0
                        },
                        new
                        {
                            Id = 6,
                            Description = "Refreshing coffee served over ice, perfect for hot summer days.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Iced Coffee",
                            Price = 3.0
                        },
                        new
                        {
                            Id = 7,
                            Description = "Cold coffee blended with milk, ice, and flavorings, creating a creamy and refreshing beverage.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Frappe",
                            Price = 4.0
                        },
                        new
                        {
                            Id = 8,
                            Description = "Our exclusive blend with floral notes and a hint of honey, perfect for those seeking an aromatic experience.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Rosmaninho Blend",
                            Price = 3.5
                        },
                        new
                        {
                            Id = 9,
                            Description = "A refreshing combination of espresso and cold milk served over ice, perfect for a hot summer day.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Iced Latte",
                            Price = 3.5
                        },
                        new
                        {
                            Id = 10,
                            Description = "Espresso combined with steamed milk and chocolate syrup, topped with whipped cream, for an indulgent coffee treat.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Mocha",
                            Price = 4.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
