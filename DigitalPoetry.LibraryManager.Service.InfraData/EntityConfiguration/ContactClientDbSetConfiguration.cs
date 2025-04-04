namespace DigitalPoetry.LibraryManager.Service.Infra.Data.EntityConfiguration
{
    using DigitalPoetry.LibraryManager.Service.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>ContactClient Entity Database Set Configuration</summary>
    internal class ContactClientDbSetConfiguration : IEntityTypeConfiguration<ContactClientEntity>
    {
        /// <summary>Configure ContactClient Entity</summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<ContactClientEntity> builder)
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

            // Relation with Client Table
            builder.HasOne(x => x.Client)
                .WithMany(x => x.ContactClientCollection)
                .HasForeignKey(x => x.ClientId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
