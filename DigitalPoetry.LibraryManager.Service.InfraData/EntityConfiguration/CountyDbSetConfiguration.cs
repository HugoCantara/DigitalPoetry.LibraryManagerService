namespace DigitalPoetry.LibraryManager.Service.Infra.Data.EntityConfiguration
{
    using DigitalPoetry.LibraryManager.Service.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>County Entity Database Set Configuration</summary>
    internal class CountyDbSetConfiguration : IEntityTypeConfiguration<CountyEntity>
    {
        /// <summary>Configure County Entity</summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<CountyEntity> builder)
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

            // Foreign Key District Identifier Field
            builder.Property(x => x.DistrictId)
                .IsUnicode(false)
                .HasColumnName("DistrictId")
                .HasColumnOrder(3)
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            // Address Description Field
            builder.Property(x => x.Description)
                .IsUnicode(false)
                .HasColumnName("Description")
                .HasColumnOrder(4)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

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

            // Relation with Country Table
            builder.HasOne(x => x.Country)
                .WithMany(x => x.CountyCollection)
                .HasForeignKey(x => x.CountryId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relation with District Table
            builder.HasOne(x => x.District)
                .WithMany(x => x.CountyCollection)
                .HasForeignKey(x => x.DistrictId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}