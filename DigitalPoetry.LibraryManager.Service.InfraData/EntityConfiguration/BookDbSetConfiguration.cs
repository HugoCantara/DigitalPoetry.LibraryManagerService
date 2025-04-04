namespace DigitalPoetry.LibraryManager.Service.Infra.Data.EntityConfiguration
{
    using DigitalPoetry.LibraryManager.Service.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>Book Entity Database Set Configuration</summary>
    internal class BookDbSetConfiguration : IEntityTypeConfiguration<BookEntity>
    {
        /// <summary>Configure Book Entity</summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<BookEntity> builder)
        {
            // Primary Key Identifier Field
            builder.HasKey(x => x.Id)
                .HasName("Id");

            // Foreign Key Author Identifier Field
            builder.Property(x => x.AuthorId)
                .IsUnicode(false)
                .HasColumnName("AuthorId")
                .HasColumnOrder(2)
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            // Book Name Field
            builder.Property(x => x.BookName)
                .IsUnicode(false)
                .HasColumnName("BookName")
                .HasColumnOrder(3)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            // Book Resume Field
            builder.Property(x => x.BookResume)
                .IsUnicode(false)
                .HasColumnName("Resume")
                .HasColumnOrder(4)
                .HasColumnType("varchar")
                .HasMaxLength(500);

            // Book Publisher Field
            builder.Property(x => x.BookPublisher)
                .IsUnicode(false)
                .HasColumnName("Publisher")
                .HasColumnOrder(5)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            // Book Publication Year Field
            builder.Property(x => x.BookPublicationYear)
                .IsUnicode(false)
                .HasColumnName("PublicationYear")
                .HasColumnOrder(6)
                .HasColumnType("datetime2(0)");

            // Book Edition Field
            builder.Property(x => x.BookEdition)
                .IsUnicode(false)
                .HasColumnName("Edition")
                .HasColumnOrder(7)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            // Status Field
            builder.Property(x => x.Status)
                .IsUnicode(false)
                .HasColumnName("Status")
                .HasColumnOrder(8)
                .HasColumnType("bit")
                .HasDefaultValue(true);

            // ********************
            // Relations.
            // ********************

            // Relation with Author Table
            builder.HasOne(x => x.Author)
                .WithMany(x => x.BookCollection)
                .HasForeignKey(x => x.AuthorId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}