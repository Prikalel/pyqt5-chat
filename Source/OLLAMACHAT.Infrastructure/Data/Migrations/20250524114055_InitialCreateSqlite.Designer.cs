﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VelikiyPrikalel.OLLAMACHAT.Infrastructure.Data;

#nullable disable

namespace VelikiyPrikalel.OLLAMACHAT.Infrastructure.Data.Migrations
{
    [DbContext(typeof(OllamaChatContext))]
    [Migration("20250524114055_InitialCreateSqlite")]
    partial class InitialCreateSqlite
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.16");

            modelBuilder.Entity("VelikiyPrikalel.OLLAMACHAT.Data.ChatMessage", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ChatId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("Time")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserChatId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserChatId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("VelikiyPrikalel.OLLAMACHAT.Data.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("VelikiyPrikalel.OLLAMACHAT.Data.UserChat", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("State")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserChats");
                });

            modelBuilder.Entity("VelikiyPrikalel.OLLAMACHAT.Data.ChatMessage", b =>
                {
                    b.HasOne("VelikiyPrikalel.OLLAMACHAT.Data.UserChat", null)
                        .WithMany("Messages")
                        .HasForeignKey("UserChatId");
                });

            modelBuilder.Entity("VelikiyPrikalel.OLLAMACHAT.Data.UserChat", b =>
                {
                    b.HasOne("VelikiyPrikalel.OLLAMACHAT.Data.User", null)
                        .WithMany("Chats")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VelikiyPrikalel.OLLAMACHAT.Data.User", b =>
                {
                    b.Navigation("Chats");
                });

            modelBuilder.Entity("VelikiyPrikalel.OLLAMACHAT.Data.UserChat", b =>
                {
                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
