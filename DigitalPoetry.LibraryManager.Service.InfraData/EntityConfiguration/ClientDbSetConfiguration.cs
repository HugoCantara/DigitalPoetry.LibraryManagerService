namespace DigitalPoetry.LibraryManager.Service.Infra.Data.EntityConfiguration
{
    using DigitalPoetry.LibraryManager.Service.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>Client Entity Database Set Configuration</summary>
    internal class ClientDbSetConfiguration : IEntityTypeConfiguration<ClientEntity>
    {
        /// <summary>Configure Client Entity</summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<ClientEntity> builder)
        {
            // Primary Key Identifier Field
            builder.HasKey(x => x.Id)
                .HasName("Id");

            // Foreign Key Address Identifier Field
            builder.Property(x => x.AddressId)
                .IsUnicode(false)
                .HasColumnName("AddressId")
                .HasColumnOrder(2)
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            // Client Taxpayer Number Field
            builder.Property(x => x.TaxpayerNumber)
                .IsUnicode(false)
                .HasColumnName("TaxpayerNumber")
                .HasColumnOrder(3)
                .HasColumnType("varchar")
                .HasMaxLength(9)
                .IsRequired();

            // Client First Name Field
            builder.Property(x => x.FirstName)
                .IsUnicode(false)
                .HasColumnName("FirstName")
                .HasColumnOrder(4)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            // Client Middle Name Field
            builder.Property(x => x.MiddleName)
                .IsUnicode(false)
                .HasColumnName("MiddleName")
                .HasColumnOrder(5)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            // Client Last Name Field
            builder.Property(x => x.LastName)
                .IsUnicode(false)
                .HasColumnName("LastName")
                .HasColumnOrder(6)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            //// Client Full Name Field
            //builder.Property(x => x.FullName)
            //    .IsUnicode(false)
            //    .HasColumnName("FullName")
            //    .HasColumnOrder(7)
            //    .HasColumnType("varchar")
            //    .HasMaxLength(300)
            //    .IsRequired();

            // Status Field
            builder.Property(x => x.Status)
                .IsUnicode(false)
                .HasColumnName("Status")
                .HasColumnOrder(8)
                .HasColumnType("bit")
                .HasDefaultValue(true);

            // ********************
            // Relations.
            // ********************

            // Relation with Address Table
            builder.HasOne(x => x.Address)
                .WithMany(x => x.ClientCollection)
                .HasForeignKey(x => x.AddressId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}