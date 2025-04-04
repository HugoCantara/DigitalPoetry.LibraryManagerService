namespace DigitalPoetry.LibraryManager.Service.Infra.Data.EntityConfiguration
{
    using DigitalPoetry.LibraryManager.Service.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>District Entity Database Set Configuration</summary>
    internal class DistrictDbSetConfiguration : IEntityTypeConfiguration<DistrictEntity>
    {
        /// <summary>Configure District Entity</summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<DistrictEntity> builder)
        {
            // Primary Key Identifier Field
            builder.HasKey(x => x.Id)
                .HasName("Id");

            // Foreign Key Country Identifier Field
            builder.Property(x => x.CountryId)
                .IsUnicode(false)
                .HasColumnName("CountryId")
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

            // Status Field
            builder.Property(x => x.Status)
                .IsUnicode(false)
                .HasColumnName("Status")
                .HasColumnOrder(4)
                .HasColumnType("bit")
                .HasDefaultValue(true);

            // ********************
            // Relations.
            // ********************

            // Relation with Country Table
            builder.HasOne(x => x.Country)
                .WithMany(x => x.DistrictCollection)
                .HasForeignKey(x => x.CountryId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}