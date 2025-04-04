namespace DigitalPoetry.LibraryManager.Service.Infra.Data.EntityConfiguration
{
    using DigitalPoetry.LibraryManager.Service.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>Country Entity Database Set Configuration</summary>
    internal class CountryDbSetConfiguration : IEntityTypeConfiguration<CountryEntity>
    {
        /// <summary>Configure Country Entity</summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<CountryEntity> builder)
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
