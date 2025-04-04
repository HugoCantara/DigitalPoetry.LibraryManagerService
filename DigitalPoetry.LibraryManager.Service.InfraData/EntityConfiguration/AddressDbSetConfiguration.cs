namespace DigitalPoetry.LibraryManager.Service.Infra.Data.EntityConfiguration
{
    using DigitalPoetry.LibraryManager.Service.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>Address Entity Database Set Configuration</summary>
    internal class AddressDbSetConfiguration : IEntityTypeConfiguration<AddressEntity>
    {
        /// <summary>Configure Address Entity</summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<AddressEntity> builder)
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

            // Foreign Key City Identifier Field
            builder.Property(x => x.CityId)
                .IsUnicode(false)
                .HasColumnName("CityId")
                .HasColumnOrder(6)
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            // Address Description Field
            builder.Property(x => x.Description)
                .IsUnicode(false)
                .HasColumnName("Description")
                .HasColumnOrder(7)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            // IsPrincipalAddress Field
            builder.Property(x => x.IsPrincipalAddress)
                .IsUnicode(false)
                .HasColumnName("IsPrincipalAddress")
                .HasColumnOrder(8)
                .HasColumnType("bit")
                .HasDefaultValue(true);

            // Status Field
            builder.Property(x => x.Status)
                .IsUnicode(false)
                .HasColumnName("Status")
                .HasColumnOrder(9)
                .HasColumnType("bit")
                .HasDefaultValue(true);

            // ********************
            // Relations.
            // ********************

            // Relation with Country Table
            builder.HasOne(x => x.Country)
                .WithMany(x => x.AddressCollection)
                .HasForeignKey(x => x.CountryId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relation with District Table
            builder.HasOne(x => x.District)
                .WithMany(x => x.AddressCollection)
                .HasForeignKey(x => x.DistrictId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relation with County Table
            builder.HasOne(x => x.County)
                .WithMany(x => x.AddressCollection)
                .HasForeignKey(x => x.CountyId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relation with Parish Table
            builder.HasOne(x => x.Parish)
                .WithMany(x => x.AddressCollection)
                .HasForeignKey(x => x.ParishId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relation with City Table
            builder.HasOne(x => x.City)
                .WithMany(x => x.AddressEntityCollection)
                .HasForeignKey(x => x.CityId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}