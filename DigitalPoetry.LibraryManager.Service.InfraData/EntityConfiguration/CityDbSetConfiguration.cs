namespace DigitalPoetry.LibraryManager.Service.Infra.Data.EntityConfiguration
{
    using DigitalPoetry.LibraryManager.Service.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>City Entity Database Set Configuration</summary>
    internal class CityDbSetConfiguration : IEntityTypeConfiguration<CityEntity>
    {
        /// <summary>Configure City Entity</summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<CityEntity> builder)
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

            // Foreign Key County Identifier Field
            builder.Property(x => x.CountyId)
                .IsUnicode(false)
                .HasColumnName("CountyId")
                .HasColumnOrder(4)
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            // Foreign Key Parish Identifier Field
            builder.Property(x => x.ParishId)
                .IsUnicode(false)
                .HasColumnName("ParishId")
                .HasColumnOrder(5)
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            // City Description Field
            builder.Property(x => x.Description)
                .IsUnicode(false)
                .HasColumnName("Description")
                .HasColumnOrder(6)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

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

            // Relation with Country Table
            builder.HasOne(x => x.Country)
                .WithMany(x => x.CityCollection)
                .HasForeignKey(x => x.CountryId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relation with District Table
            builder.HasOne(x => x.District)
                .WithMany(x => x.CityCollection)
                .HasForeignKey(x => x.DistrictId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relation with County Table
            builder.HasOne(x => x.County)
                .WithMany(x => x.CityCollection)
                .HasForeignKey(x => x.CountyId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relation with Parish Table
            builder.HasOne(x => x.Parish)
                .WithMany(x => x.CityCollection)
                .HasForeignKey(x => x.ParishId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}