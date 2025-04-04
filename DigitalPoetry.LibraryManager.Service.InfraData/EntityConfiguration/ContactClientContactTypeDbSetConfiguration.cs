namespace DigitalPoetry.LibraryManager.Service.Infra.Data.EntityConfiguration
{
    using DigitalPoetry.LibraryManager.Service.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>ContactClientContactType Entity Database Set Configuration</summary>
    internal class ContactClientContactTypeDbSetConfiguration : IEntityTypeConfiguration<ContactClientContactTypeEntity>
    {
        /// <summary>Configure ContactClientContactType Entity</summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<ContactClientContactTypeEntity> builder)
        {
            // Primary Key Identifier Field
            builder.HasKey(x => x.Id)
                .HasName("Id");

            // Foreign Key ContactClient Identifier Field
            builder.Property(x => x.ContactClientId)
                .IsUnicode(false)
                .HasColumnName("ContactClientId")
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

            // Relation with ContactClient Table
            builder.HasOne(x => x.ContactClient)
                .WithMany(x => x.ContactClientContactTypeCollection)
                .HasForeignKey(x => x.ContactClientId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relation with ContactType Table
            builder.HasOne(x => x.ContactType)
                .WithMany(x => x.ContactClientContactTypeCollection)
                .HasForeignKey(x => x.ContactTypeId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}