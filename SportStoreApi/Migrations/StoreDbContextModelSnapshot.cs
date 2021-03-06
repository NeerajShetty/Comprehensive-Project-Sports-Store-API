// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportStoreApi.Models;

namespace SportStoreApi.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportStoreApi.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<long>("ContactNumber");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SportStoreApi.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color");

                    b.Property<string>("Name");

                    b.Property<int?>("OrderId");

                    b.Property<double>("Price");

                    b.Property<int>("Size");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("SportStoreApi.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<int>("ItemID");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("OrderNo");

                    b.Property<string>("PaymentMode");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SportStoreApi.Models.Item", b =>
                {
                    b.HasOne("SportStoreApi.Models.Order", "Orders")
                        .WithMany("Item")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("SportStoreApi.Models.Order", b =>
                {
                    b.HasOne("SportStoreApi.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
