namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>Address Entity</summary>
    public class AddressEntity
    {
        /// <summary>Address Identifier</summary>
        [Required]
        [Column("Id")]
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

        /// <summary>City Identifier</summary>
        public int CityId { get; private set; }

        /// <summary>City Entity</summary>
        public CityEntity City { get; set; }

        /// <summary>Address</summary>
        [Required]
        [StringLength(200, ErrorMessage = EntityValidationConstants.ADDRESS_DESCRIPTION_LENGTH)]
        [Column("Description")]
        public string Description { get; private set; }

        /// <summary>Is Principal Address</summary>
        [Required]
        [Column("IsPrincipalAddress")]
        public bool IsPrincipalAddress { get; private set; }

        /// <summary>Address Status</summary>
        [Required]
        [Column("Status")]
        public bool Status { get; private set; }

        /// <summary>Address Entity Constructor</summary>
        /// <param name="id">Address Identifier</param>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="districtId">District Identifier</param>
        /// <param name="countyId">County Identifier</param>
        /// <param name="parishId">Parish Identifier</param>
        /// <param name="cityId">City Identifier</param>
        /// <param name="description">Address Description</param>
        /// <param name="isPrincipalAddress">Is Principal Address</param>
        /// <param name="status">Address Status</param>
        public AddressEntity(int id, int countryId, int districtId, int countyId, int parishId, int cityId, string description, bool isPrincipalAddress, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.AddressId);
            this.CreateAndValidate(countryId, districtId, countyId, parishId, cityId, description, isPrincipalAddress, status);
        }

        /// <summary>Address Entity Constructor</summary>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="districtId">District Identifier</param>
        /// <param name="countyId">County Identifier</param>
        /// <param name="parishId">Parish Identifier</param>
        /// <param name="cityId">City Identifier</param>
        /// <param name="description">Address Description</param>
        /// <param name="isPrincipalAddress">Is Principal Address</param>
        /// <param name="status">Address Status</param>
        public AddressEntity(int countryId, int districtId, int countyId, int parishId, int cityId, string description, bool isPrincipalAddress, bool status)
        {
            this.CreateAndValidate(countryId, districtId, countyId, parishId, cityId, description, isPrincipalAddress, status);
        }

        /// <summary>Create and Validate Address</summary>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="districtId">District Identifier</param>
        /// <param name="countyId">County Identifier</param>
        /// <param name="parishId">Parish Identifier</param>
        /// <param name="cityId">City Identifier</param>
        /// <param name="description">Address Description</param>
        /// <param name="isPrincipalAddress">Is Principal Address</param>
        /// <param name="status">Address Status</param>
        public void CreateAndValidate(int countryId, int districtId, int countyId, int parishId, int cityId, string description, bool isPrincipalAddress, bool status)
        {
            this.CountryId = countryId.ValidateProperty(IdentifierPropertyEnum.CountryId);
            this.DistrictId = districtId.ValidateProperty(IdentifierPropertyEnum.DistrictId);
            this.CountyId = countyId.ValidateProperty(IdentifierPropertyEnum.CountyId);
            this.ParishId = parishId.ValidateProperty(IdentifierPropertyEnum.ParishId);
            this.CityId = cityId.ValidateProperty(IdentifierPropertyEnum.CityId);
            this.Description = description.ValidateProperty(DescriptionPropertyEnum.AddressDescription, 200);
            this.IsPrincipalAddress = isPrincipalAddress;
            this.Status = status;
        }

        /// <summary>Update Address</summary>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="districtId">District Identifier</param>
        /// <param name="countyId">County Identifier</param>
        /// <param name="parishId">Parish Identifier</param>
        /// <param name="cityId">City Identifier</param>
        /// <param name="description">Address Description</param>
        /// <param name="isPrincipalAddress">Is Principal Address</param>
        /// <param name="status">Address Status</param>
        public void Update(int countryId, int districtId, int countyId, int parishId, int cityId, string description, bool isPrincipalAddress, bool status)
        {
            this.CreateAndValidate(countryId, districtId, countyId, parishId, cityId, description, isPrincipalAddress, status);
        }  
    }
}
