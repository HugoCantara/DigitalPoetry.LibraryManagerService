namespace DigitalPoetry.LibraryManager.Service.Infra.Data.Context
{
    using DigitalPoetry.LibraryManager.Service.Domain.Entities;
    using Microsoft.EntityFrameworkCore;

    /// <summary>Application Database Context</summary>
    public class ApplicationDbContext : DbContext
    {
        /// <summary>Application Database Context Constructor</summary>
        /// <param name="options">Database Context Options</param>
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        /// <summary>Client Database Set</summary>
        public DbSet<ClientEntity> ClientDbSet { get; set; }

        /// <summary>Author Database Set</summary>
        public DbSet<AuthorEntity> AuthorDbSet { get; set; }

        /// <summary>Book Database Set</summary>
        public DbSet<BookEntity> BookDbSet { get; set; }

        /// <summary>Loan Database Set</summary>
        public DbSet<LoanEntity> LoanDbSet { get; set; }

        /// <summary>ContactType Database Set</summary>
        public DbSet<ContactTypeEntity> ContactTypeDbSet { get; set; }

        /// <summary>Address Database Set</summary>
        public DbSet<AddressEntity> AddressDbSet { get; set; }

        /// <summary>Country Database Set</summary>
        public DbSet<CountryEntity> CountryDbSet { get; set; }

        /// <summary>District Database Set</summary>
        public DbSet<DistrictEntity> DistrictDbSet { get; set; }

        /// <summary>County Database Set</summary>
        public DbSet<CountyEntity> CountyDbSet { get; set; }

        /// <summary>Parish Database Set</summary>
        public DbSet<ParishEntity> ParishDbSet { get; set; }

        /// <summary>City Database Set</summary>
        public DbSet<CityEntity> CityDbSet { get; set; }

        /// <summary>ContactClient Database Set</summary>
        public DbSet<ContactClientEntity> ContactClientDbSet { get; set; }

        /// <summary>ContactAuthor Database Set</summary>
        public DbSet<ContactAuthorEntity> ContactAuthorDbSet { get; set; }

        /// <summary>ContactClientContactType Database Set</summary>
        public DbSet<ContactClientContactTypeEntity> ContactClientContactTypeDbSet { get; set; }

        /// <summary>ContactAuthorContactType Database Set</summary>
        public DbSet<ContactAuthorContactTypeEntity> ContactAuthorContactTypeDbSet { get; set; }

        /// <summary>On Model Creating</summary>
        /// <param name="builder">Model Builder</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Search configurations of entities in project Infra
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}