namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;

    /// <summary>ContactClient Entity</summary>
    public class ContactClientEntity
    {
        /// <summary>Primary Key ContactClient Identifier Property</summary>
        public Guid Id { get; private set; }

        /// <summary>Foreign Kay Client Identifier Property</summary>
        public Guid ClientId { get; private set; }

        /// <summary>Client Entity</summary>
        public ClientEntity Client { get; set; }

        /// <summary>Description Property</summary>
        public string Description { get; private set; }

        /// <summary>ContactClientContactType Entity Collection</summary>
        public ICollection<ContactClientContactTypeEntity> ContactClientContactTypeCollection { get; set; }

        /// <summary>ContactClient Entity Constructor</summary>
        /// <param name="id">Primary Key ContactClient Identifier Parameter</param>
        /// <param name="clientId">Foreign Key Client Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        public ContactClientEntity(Guid id, Guid clientId, string description)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.ContactClientId);
            this.CreateAndValidate(clientId, description);
        }

        /// <summary>ContactClient Entity Constructor</summary>
        /// <param name="clientId">Foreign Key Client Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        public ContactClientEntity(Guid clientId, string description)
        {
            this.CreateAndValidate(clientId, description);
        }

        /// <summary>Create and Validate ContactClient</summary>
        /// <param name="clientId">Foreign Key Client Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        public void CreateAndValidate(Guid clientId, string description)
        {
            this.ClientId = clientId.ValidateProperty(IdentifierPropertyEnum.ClientId);
            this.Description = description.ValidateProperty(DescriptionPropertyEnum.DistrictDescription, 50);
        }

        /// <summary>Update ContactClient</summary>
        /// <param name="clientId">Foreign Key Client Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        public void Update(Guid clientId, string description)
        {
            this.CreateAndValidate(clientId, description);
        }   
    }
}