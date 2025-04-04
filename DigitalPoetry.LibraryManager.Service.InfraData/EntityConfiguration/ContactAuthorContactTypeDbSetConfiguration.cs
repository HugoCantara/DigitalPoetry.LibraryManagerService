namespace DigitalPoetry.LibraryManager.Service.Infra.Data.EntityConfiguration
{
    using DigitalPoetry.LibraryManager.Service.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>ContactAuthorContactType Entity Database Set Configuration</summary>
    internal class ContactAuthorContactTypeDbSetConfiguration : IEntityTypeConfiguration<ContactAuthorContactTypeEntity>
    {
        /// <summary>Configure ContactAuthorContactType Entity</summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<ContactAuthorContactTypeEntity> builder)
        {
            // Primary Key Identifier Field
            builder.HasKey(x => x.Id)
                .HasName("Id");

            // Foreign Key ContactAuthor Identifier Field
            builder.Property(x => x.ContactAuthorId)
                .IsUnicode(false)
                .HasColumnName("ContactAuthorId")
                .HasColumnOrder(2)
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            // Foreign Key ContactType Identifier Field
            builder.Property(x => x.ContactTypeId)
                .IsUnicode(false)
                .HasColumnName("ContactTypeId")
                .HasColumnOrder(3)
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            // IsPrincipalContact Field
            builder.Property(x => x.IsPrincipalContact)
                .IsUnicode(false)
                .HasColumnName("IsPrincipalContact")
                .HasColumnOrder(4)
                .HasColumnType("bit")
                .HasDefaultValue(true);

            // Status Field
            builder.Property(x => x.Status)
                .IsUnicode(false)
                .HasColumnName("Status")
                .HasColumnOrder(5)
                .HasColumnType("bit")
                .HasDefaultValue(true);

            // ********************
            // Relations.
            // ********************

            // Relation with ContactAuthor Table
            builder.HasOne(x => x.ContactAuthor)
                .WithMany(x => x.ContactAuthorContactTypeCollection)
                .HasForeignKey(x => x.ContactAuthorId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relation with ContactType Table
            builder.HasOne(x => x.ContactType)
                .WithMany(x => x.ContactAuthorContactTypeCollection)
                .HasForeignKey(x => x.ContactTypeId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}