﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WordsBweb.Data;

namespace WordsBweb.Migrations
{
    [DbContext(typeof(WordsContext))]
    [Migration("20200330091942_Third")]
    partial class Third
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("WordsBweb.Models.Words", b =>
                {
                    b.Property<int>("WordsID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("WordEng");

                    b.Property<string>("WordPol");

                    b.HasKey("WordsID");

                    b.ToTable("WordsA");
                });
#pragma warning restore 612, 618
        }
    }
}
