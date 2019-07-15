﻿// <auto-generated />
using EventCatalogAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventCatalogAPI.Migrations
{
    [DbContext(typeof(EventContext))]
    [Migration("20190714180141_third")]
    partial class third
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:.event_category_hilo", "'event_category_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.event_start_date_hilo", "'event_start_date_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.event_venue_hilo", "'event_venue_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.events_hilo", "'events_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventCatalogAPI.Domains.EventCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "event_category_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("EventCategories");
                });

            modelBuilder.Entity("EventCatalogAPI.Domains.EventItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "events_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("EventAddress");

                    b.Property<int>("EventCategoryId");

                    b.Property<string>("EventCity");

                    b.Property<decimal>("EventCost");

                    b.Property<string>("EventDescription");

                    b.Property<string>("EventEndDate");

                    b.Property<string>("EventEndTime");

                    b.Property<bool>("EventFavorite");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("EventPictureUrl");

                    b.Property<int>("EventStartDateId");

                    b.Property<string>("EventStartTime");

                    b.Property<string>("EventState");

                    b.Property<int>("EventTicketsAvailable");

                    b.Property<string>("EventUrl");

                    b.Property<int>("EventVenueId");

                    b.Property<int>("EventZip");

                    b.HasKey("Id");

                    b.HasIndex("EventCategoryId");

                    b.HasIndex("EventStartDateId");

                    b.HasIndex("EventVenueId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("EventCatalogAPI.Domains.EventStartDate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "event_start_date_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("StartDate")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("EventStartDates");
                });

            modelBuilder.Entity("EventCatalogAPI.Domains.EventVenue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "event_venue_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Venue")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("EventVenues");
                });

            modelBuilder.Entity("EventCatalogAPI.Domains.EventItem", b =>
                {
                    b.HasOne("EventCatalogAPI.Domains.EventCategory", "EventCategory")
                        .WithMany()
                        .HasForeignKey("EventCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EventCatalogAPI.Domains.EventStartDate", "EventStartDate")
                        .WithMany()
                        .HasForeignKey("EventStartDateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EventCatalogAPI.Domains.EventVenue", "EventVenue")
                        .WithMany()
                        .HasForeignKey("EventVenueId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}