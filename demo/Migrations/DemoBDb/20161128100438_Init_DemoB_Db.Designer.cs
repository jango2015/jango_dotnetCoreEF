using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using demo.Data;

namespace demo.Migrations.DemoBDb
{
    [DbContext(typeof(DemoBDbContext))]
    [Migration("20161128100438_Init_DemoB_Db")]
    partial class Init_DemoB_Db
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1");

            modelBuilder.Entity("demo.Models.DemoB", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("DemoBs");
                });
        }
    }
}
