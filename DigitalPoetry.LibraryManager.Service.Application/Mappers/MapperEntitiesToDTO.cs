namespace DigitalPoetry.LibraryManager.Service.Application.Mappers
{
    using AutoMapper;
    using DigitalPoetry.LibraryManager.Service.Application.DTOs;
    using DigitalPoetry.LibraryManager.Service.Domain.Entities;

    /// <summary>Mapper Entities to Data Transfer Object</summary>
    public class MapperEntitiesToDTO : Profile
    {
        /// <summary>Mapper Entities to Data Transfer Object Constructor</summary>
        public MapperEntitiesToDTO()
        {
            CreateMap<AddressEntity, AddressDTO>().ReverseMap();
            CreateMap<AuthorEntity, AuthorDTO>().ReverseMap();
            CreateMap<BookEntity, BookDTO>().ReverseMap();
            CreateMap<CityEntity, CityDTO>().ReverseMap();
            CreateMap<ClientEntity, ClientDTO>().ReverseMap();
            CreateMap<ContactAuthorContactTypeEntity, ContactAuthorContactTypeDTO>().ReverseMap();
            CreateMap<ContactAuthorEntity, ContactAuthorDTO>().ReverseMap();
            CreateMap<ContactClientContactTypeEntity, ContactClientContactTypeDTO>().ReverseMap();
            CreateMap<ContactClientEntity, ContactClientDTO>().ReverseMap();
            CreateMap<ContactTypeEntity, ContactTypeDTO>().ReverseMap();
            CreateMap<CountryEntity, CountryDTO>().ReverseMap();
            CreateMap<CountyEntity, CountyDTO>().ReverseMap();
            CreateMap<DistrictEntity, DistrictDTO>().ReverseMap();
            CreateMap<LoanEntity, LoanDTO>().ReverseMap();
            CreateMap<ParishEntity, ParishDTO>().ReverseMap();
        }
    }
}