namespace DigitalPoetry.LibraryManager.Service.Infra.Data.EntityConfiguration
{
    using DigitalPoetry.LibraryManager.Service.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>Loan Entity Database Set Configuration</summary>
    internal class LoanDbSetConfiguration : IEntityTypeConfiguration<LoanEntity>
    {
        /// <summary>Configure Loan Entity</summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<LoanEntity> builder)
        {
            // Primary Key Identifier Field
            builder.HasKey(x => x.Id)
                .HasName("Id");

            // Foreign Key Client Identifier Field
            builder.Property(x => x.ClientId)
                .IsUnicode(false)
                .HasColumnName("ClientId")
                .HasColumnOrder(2)
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            // Foreign Key Book Identifier Field
            builder.Property(x => x.BookId)
                .IsUnicode(false)
                .HasColumnName("BookId")
                .HasColumnOrder(3)
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            // LoanDate Field
            builder.Property(x => x.LoanDate)
                .IsUnicode(false)
                .HasColumnName("LoanDate")
                .HasColumnOrder(4)
                .HasColumnType("datetime2(0)");

            // DeliveryDate Field
            builder.Property(x => x.DeliveryDate)
                .IsUnicode(false)
                .HasColumnName("DeliveryDate")
                .HasColumnOrder(5)
                .HasColumnType("datetime2(0)");

            // IsDelivered Field
            builder.Property(x => x.IsDelivered)
                .IsUnicode(false)
                .HasColumnName("IsDelivered")
                .HasColumnOrder(6)
                .HasColumnType("bit")
                .HasDefaultValue(true);

            // Status Field
            builder.Property(x => x.Status)
                .IsUnicode(false)
                .HasColumnName("Status")
                .HasColumnOrder(7)
                .HasColumnType("bit")
                .HasDefaultValue(true);

            // ********************
            // Relations.
            // ********************

            // Relation with Client Table
            builder.HasOne(x => x.Client)
                .WithMany(x => x.LoanCollection)
                .HasForeignKey(x => x.ClientId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relation with Book Table
            builder.HasOne(x => x.Book)
                .WithMany(x => x.LoanCollection)
                .HasForeignKey(x => x.BookId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}