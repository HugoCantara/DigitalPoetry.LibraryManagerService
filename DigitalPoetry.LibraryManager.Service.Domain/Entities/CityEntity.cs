namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>City Entity</summary>
    public class CityEntity
    {
        /// <summary>City Identifier</summary>
        public int Id { get; private set; }

        /// <summary>Country Identifier</summary>
        [Required]
        [Column("CountryId")]
        public int CountryId { get; private set; }

        /// <summary>Country Entity</summary>
        public CountryEntity Country { get; set; }

        /// <summary>District Identifier</summary>
        [Required]
        [Column("DistrictId")]
        public int DistrictId { get; private set; }

        /// <summary>District Entity</summary>
        public DistrictEntity District { get; set; }

        /// <summary>County Identifier</summary>
        [Required]
        [Column("CountyId")]
        public int CountyId { get; private set; }

        /// <summary>County Entity</summary>
        public CountyEntity County { get; set; }

        /// <summary>Parish Identifier</summary>
        [Required]
        [Column("ParishId")]
        public int ParishId { get; private set; }

        /// <summary>Parish Entity</summary>
        public ParishEntity Parish { get; set; }

        /// <summary>Parish Description</summary>
        [Required]
        [StringLength(50, ErrorMessage = EntityValidationConstants.CITY_DESCRIPTION_LENGTH)]
        [Column("Description")]
        public string Description { get; private set; }

        /// <summary>Parish Status</summary>
        [Required]
        [Column("Status")]
        public bool Status { get; private set; }

        /// <summary>City Entity Constructor</summary>
        /// <param name="id">City Identifier</param>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="districtId">District Identifier</param>
        /// <param name="countyId">County Identifier</param>
        /// <param name="parishId">Parish Identifier</param>
        /// <param name="description">City Description</param>
        /// <param name="status">City Status</param>
        public CityEntity(int id, int countryId, int districtId, int countyId, int parishId, string description, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.CityId);
            this.CreateAndValidate(countryId, districtId, countyId, parishId, description, status);
        }

        /// <summary>City Entity Constructor</summary>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="districtId">District Identifier</param>
        /// <param name="countyId">County Identifier</param>
        /// <param name="parishId">Parish Identifier</param>
        /// <param name="cityName">City Name</param>
        /// <param name="status">City Status</param>
        public CityEntity(int countryId, int districtId, int countyId, int parishId, string cityName, bool status)
        {
            this.CreateAndValidate(countryId, districtId, countyId, parishId, cityName, status);
        }

        /// <summary>Create and Validate City</summary>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="districtId">District Identifier</param>
        /// <param name="countyId">County Identifier</param>
        /// <param name="parishId">Parish Identifier</param>
        /// <param name="description">City Description</param>
        /// <param name="status">City Status</param>
        public void CreateAndValidate(int countryId, int districtId, int countyId, int parishId, string description, bool status)
        {
            this.CountryId = countryId.ValidateProperty(IdentifierPropertyEnum.CountryId);
            this.DistrictId = districtId.ValidateProperty(IdentifierPropertyEnum.DistrictId);
            this.CountyId = countyId.ValidateProperty(IdentifierPropertyEnum.CountyId);
            this.ParishId = parishId.ValidateProperty(IdentifierPropertyEnum.ParishId);
            this.Description = description.ValidateProperty(DescriptionPropertyEnum.CityDescription, 50);
            this.Status = status;
        }

        /// <summary>Update City</summary>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="districtId">District Identifier</param>
        /// <param name="countyId">County Identifier</param>
        /// <param name="parishId">Parish Identifier</param>
        /// <param name="cityName">City Name</param>
        /// <param name="status">City Status</param>
        public void Update(int countryId, int districtId, int countyId, int parishId, string cityName, bool status)
        {
            this.CreateAndValidate(countryId, districtId, countyId, parishId, cityName, status);
        }  
    }
}
