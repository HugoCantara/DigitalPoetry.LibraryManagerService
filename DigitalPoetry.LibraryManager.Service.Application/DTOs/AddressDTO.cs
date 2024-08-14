namespace DigitalPoetry.LibraryManager.Service.Application.DTOs
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>Address Data Transfer Object</summary>
    public class AddressDTO
    {
        /// <summary>Primary Key Address Identifier</summary>
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>Foreign Key Country Identifier</summary>
        [Required]
        public int CountryId { get; set; }

        /// <summary>Foreign Key District Identifier</summary>
        [Required]
        public int DistrictId { get; set; }

        /// <summary>Foreign Key County Identifier</summary>
        [Required]
        public int CountyId { get; set; }

        /// <summary>Foreign Key Parish Identifier</summary>
        [Required]
        public int ParishId { get; set; }

        /// <summary>Foreign Key City Identifier</summary>
        [Required]
        public int CityId { get; set; }

        /// <summary>Address Description</summary>
        [Required]
        [StringLength(200, ErrorMessage = EntityValidationConstants.ADDRESS_DESCRIPTION_LENGTH)]
        public string Description { get; set; }

        /// <summary>Is Principal Address</summary>
        [Required]
        public bool IsPrincipalAddress { get; set; }

        /// <summary>Address Status</summary>
        [Required]
        public bool Status { get; set; }
    }
}