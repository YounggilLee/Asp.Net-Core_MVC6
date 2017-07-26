using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Note.DAL.DataContext;

namespace Note.DAL.Migrations
{
    [DbContext(typeof(NoteDbContext))]
    [Migration("20170726140736_NoteDb1")]
    partial class NoteDb1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Note.Model.Notice", b =>
                {
                    b.Property<int>("NoticeNo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NoticeContents")
                        .IsRequired();

                    b.Property<string>("NoticeTitle")
                        .IsRequired();

                    b.Property<DateTime>("NoticeWriteDate");

                    b.HasKey("NoticeNo");

                    b.ToTable("Notices");
                });
        }
    }
}
