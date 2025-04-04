namespace DigitalPoetry.LibraryManager.Service.Infra.Data.EntityConfiguration
{
    using DigitalPoetry.LibraryManager.Service.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>ContactType Entity Database Set Configuration</summary>
    internal class ContactTypeDbSetConfiguration : IEntityTypeConfiguration<ContactTypeEntity>
    {
        /// <summary>Configure ContactType Entity</summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<ContactTypeEntity> builder)
        {
            // Primary Key Identifier Field
            builder.HasKey(x => x.Id)
                .HasName("Id");

            // Address Description Field
            builder.Property(x => x.Description)
                .IsUnicode(false)
                .HasColumnName("Description")
                .HasColumnOrder(2)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            // Status Field
            builder.Property(x => x.Status)
                .IsUnicode(false)
                .HasColumnName("Status")
                .HasColumnOrder(3)
                .HasColumnType("bit")
                .HasDefaultValue(true);
        }
    }
}