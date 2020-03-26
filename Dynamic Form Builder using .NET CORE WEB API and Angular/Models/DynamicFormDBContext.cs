using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Dynamic_Form_Builder_using_.NET_CORE_WEB_API_and_Angular.Models
{
    public partial class DynamicFormDBContext : DbContext
    {
        public DynamicFormDBContext()
        {
        }

        public DynamicFormDBContext(DbContextOptions<DynamicFormDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblFormItem> TblFormItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblFormItem>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("tbl_formItem");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Label)
                    .HasColumnName("label")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OptionId)
                    .HasColumnName("option_id")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Placeholder)
                    .HasColumnName("placeholder")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Required).HasColumnName("required");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
