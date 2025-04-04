namespace DigitalPoetry.LibraryManager.Service.Infra.Data.EntityConfiguration
{
    using DigitalPoetry.LibraryManager.Service.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>ContactAuthor Entity Database Set Configuration</summary>
    internal class ContactAuthorDbSetConfiguration : IEntityTypeConfiguration<ContactAuthorEntity>
    {
        /// <summary>Configure ContactAuthor Entity</summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<ContactAuthorEntity> builder)
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

            // Address Description Field
            builder.Property(x => x.Description)
                .IsUnicode(false)
                .HasColumnName("Description")
                .HasColumnOrder(3)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            // ********************
            // Relations.
            // ********************

            // Relation with Author Table
            builder.HasOne(x => x.Author)
                .WithMany(x => x.ContactAuthorCollection)
                .HasForeignKey(x => x.AuthorId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}