namespace DigitalPoetry.LibraryManager.Service.Tests.Domain.Entity
{
    using DigitalPoetry.LibraryManager.Service.Domain.Entities;
    using DigitalPoetry.LibraryManager.Service.Domain.Exceptions;
    using System;
    using Xunit;

    /// <summary>Address Entity Tests</summary>
    public class AddressEntityTests
    {
        ///// <summary>Address Entity Tests Constructor</summary>
        //public AddressEntityTests()
        //{

        //}

        //[Fact]
        //public void ShouldReturnSuccessWhenCreateNewAddress()
        //{
        //    // Arrange
        //    var AddressEntity = new AddressEntity();
        //    int correctId = 1;
        //    int correctCountryId = 1;
        //    int correctDistrictId = 1;
        //    int correctCountyId = 1;
        //    int correctParishId = 1;
        //    int correctCityId = 1;
        //    string correctDescription = "Correct Description";
        //    bool correctIsPrincipalAddress = true;
        //    bool correctStatus = true;
        //    var expected = new AddressEntity(correctId, correctCountryId, correctDistrictId, correctCountyId, correctParishId, correctCityId, correctDescription, correctIsPrincipalAddress, correctStatus);

        //    // Act
        //    Action act = () => AddressEntity.CreateAndValidate(0, 1, 1, 1, 1, "Description", true, true);

        //    // Assert
        //    EntitiesExceptionValidation exception = Assert.Throws<EntitiesExceptionValidation>(act);
        //    //The thrown exception can be used for even more detailed assertions.
        //    Assert.Equal("Country identifier must be positive.", exception.Message);
        //}

        //[Fact]
        //public void ShouldReturnSuccessWhenAddressEntityDataIsCorrect()
        //{
        //    // Arrange
        //    int correctId = 1;
        //    int correctCountryId = 1;
        //    int correctDistrictId = 1;
        //    int correctCountyId = 1;
        //    int correctParishId = 1;
        //    int correctCityId = 1;
        //    string correctDescription = "Correct Description";
        //    bool correctIsPrincipalAddress = true;
        //    bool correctStatus = true;
        //    var expected = new AddressEntity(correctId, correctCountryId, correctDistrictId, correctCountyId, correctParishId, correctCityId, correctDescription, correctIsPrincipalAddress, correctStatus);

        //    // Act
        //    var result = new AddressEntity(correctId, correctCountryId, correctDistrictId, correctCountyId, correctParishId, correctCityId, correctDescription, correctIsPrincipalAddress, correctStatus);

        //    // Assert
        //    Assert.Equal(expected.Id, result.Id);
        //}

        //[Fact]
        //public void ShouldReturnExceptionWhenAddressIdIsZero()
        //{
        //    // Arrange
        //    int correctId = 0;
        //    int correctCountryId = 1;
        //    int correctDistrictId = 1;
        //    int correctCountyId = 1;
        //    int correctParishId = 1;
        //    int correctCityId = 1;
        //    string correctDescription = "Correct Description";
        //    bool correctIsPrincipalAddress = true;
        //    bool correctStatus = true;

        //    // Act
        //    void act() 
        //    {
        //        new AddressEntity(correctId, correctCountryId, correctDistrictId, correctCountyId, correctParishId, correctCityId, correctDescription, correctIsPrincipalAddress, correctStatus);
        //    }

        //    // Assert
        //    EntitiesExceptionValidation exception = Assert.Throws<EntitiesExceptionValidation>(act);
        //    //The thrown exception can be used for even more detailed assertions.
        //    Assert.Equal("Address identifier must be positive.", exception.Message);
        //}
    }
}