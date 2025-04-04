namespace DigitalPoetry.LibraryManager.Service.Application.DTOs
{
    using DigitalPoetry.LibraryManager.Service.Domain.Messages;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>Address Data Transfer Object</summary>
    public class AddressDTO
    {
        /// <summary>Primary Key Address Identifier</summary>
        [IgnoreDataMember]
        public Guid Id { get; set; }

        /// <summary>Foreign Key Country Identifier</summary>
        [Required]
        public Guid CountryId { get; set; }

        /// <summary>Foreign Key District Identifier</summary>
        [Required]
        public Guid DistrictId { get; set; }

        /// <summary>Foreign Key County Identifier</summary>
        [Required]
        public Guid CountyId { get; set; }

        /// <summary>Foreign Key Parish Identifier</summary>
        [Required]
        public Guid ParishId { get; set; }

        /// <summary>Foreign Key City Identifier</summary>
        [Required]
        public Guid CityId { get; set; }

        /// <summary>Address Description</summary>
        [Required]
        [StringLength(200, ErrorMessage = ErrorMessageConstants.ADDRESS_DESCRIPTION_LENGTH)]
        public string? Description { get; set; }

        /// <summary>Is Principal Address</summary>
        [Required]
        public bool IsPrincipalAddress { get; set; }

        /// <summary>Address Status</summary>
        [Required]
        public bool Status { get; set; }
    }
}