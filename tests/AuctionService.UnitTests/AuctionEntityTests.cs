using AuctionService.Entities;

namespace AuctionService.UnitTests;

public class AuctionEntityTests
{
    //Method_Scenario_ExpectedResult
    [Fact]
    public void HasReservedPrice_ReservedPriceGtZero_True()
    {
        //arrange
        var auction = new Auction
        {
            Id = Guid.NewGuid(),
            ReservePrice = 10
        };

        //act
        var result = auction.HasReservedPrice();

        Assert.True(result);
    }

    [Fact]
    public void HasReservedPrice_ReservedPriceIsZero_False()
    {
        //arrange
        var auction = new Auction
        {
            Id = Guid.NewGuid(),
            ReservePrice = 0
        };

        //act
        var result = auction.HasReservedPrice();

        Assert.False(result);
    }
}