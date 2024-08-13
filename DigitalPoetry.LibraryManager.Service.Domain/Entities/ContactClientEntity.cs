namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>Contact Client Entity</summary>
    public class ContactClientEntity
    {
        /// <summary>Contact Client Identifier</summary>
        [Required]
        [Column("Id")]
        public int Id { get; private set; }

        /// <summary>Client Identifier</summary>
        [Required]
        [Column("ClientId")]
        public int ClientId { get; private set; }

        /// <summary>Client Entity</summary>
        public ClientEntity Client { get; set; }

        /// <summary>Contact Client Description</summary>
        [Required]
        [StringLength(50, ErrorMessage = EntityValidationConstants.CONTACT_CLIENT_DESCRIPTION_LENGTH)]
        [Column("Description")]
        public string Description { get; private set; }

        /// <summary>Contact Client Contact Type Collection</summary>
        public ICollection<ContactClientContactTypeEntity> ContactClientContactTypeCollection { get; set; }

        /// <summary>Contact Client Entity Constructor</summary>
        /// <param name="id">Contact Client Identifier</param>
        /// <param name="clientId">Client Identifier</param>
        /// <param name="description">Contact Client Description</param>
        public ContactClientEntity(int id, int clientId, string description)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.ContactClientId);
            this.CreateAndValidate(clientId, description);
        }

        /// <summary>Contact Client Entity Constructor</summary>
        /// <param name="clientId">Client Identifier</param>
        /// <param name="description">Contact Client Description</param>
        public ContactClientEntity(int clientId, string description)
        {
            this.CreateAndValidate(clientId, description);
        }

        /// <summary>Create and Validate Contact Client</summary>
        /// <param name="clientId">Client Identifier</param>
        /// <param name="description">Contact Client Description</param>
        public void CreateAndValidate(int clientId, string description)
        {
            this.ClientId = clientId.ValidateProperty(IdentifierPropertyEnum.ClientId);
            this.Description = description.ValidateProperty(DescriptionPropertyEnum.DistrictDescription, 50);
        }

        /// <summary>Update Contact Client</summary>
        /// <param name="clientId">Client Identifier</param>
        /// <param name="description">Contact Client Description</param>
        public void Update(int clientId, string description)
        {
            this.CreateAndValidate(clientId, description);
        }   
    }
}