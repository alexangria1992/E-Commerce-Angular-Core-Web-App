using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using E_Commerce_Core_Angular.Models;

namespace ECommerceCoreAngular.Migrations
{
    [DbContext(typeof(E_Commerce_Core_Angular.Models.AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("E_Commerce_Core_Angular.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.Property<DateTime>("CreatedDate");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("E_Commerce_Core_Angular.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoriesId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("E_Commerce_Core_Angular.Models.Post", b =>
                {
                    b.HasOne("E_Commerce_Core_Angular.Models.Category", "Categories")
                        .WithMany("Posts")
                        .HasForeignKey("CategoriesId");
                });
        }
    }
}
