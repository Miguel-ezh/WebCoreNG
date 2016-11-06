using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebCoreNG.Dal;

namespace WebCoreNG.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20161106031201_schema-v1")]
    partial class schemav1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("WebCoreNG.Dal.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AlexaRank");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 500);

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("WebCoreNG.Dal.Entities.Submission", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("EmailSend")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 50);

                    b.Property<DateTime>("ExpireDate");

                    b.Property<string>("Network")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 50);

                    b.HasKey("Id");

                    b.ToTable("Submissions");
                });

            modelBuilder.Entity("WebCoreNG.Dal.Entities.SubmissionAccountLookup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountId");

                    b.Property<string>("SubmissionId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("SubmissionId");

                    b.ToTable("SubmissionAccountLookups");
                });

            modelBuilder.Entity("WebCoreNG.Dal.Entities.SubmissionAccountLookup", b =>
                {
                    b.HasOne("WebCoreNG.Dal.Entities.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebCoreNG.Dal.Entities.Submission", "Submission")
                        .WithMany("SubmissionAccountLookups")
                        .HasForeignKey("SubmissionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
