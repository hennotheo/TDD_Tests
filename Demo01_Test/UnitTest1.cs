using Demo01_Core;

namespace Demo01_Test;

public class UnitTest1
{
    private readonly string[] _testCities =
    [
        "Amsterdam",
        "Berlin",
        "London",
        "New York",
        "Paris",
        "Rome",
        "Tokyo",
        "Vienna",
        "Vancouver",
        "Valencia"
    ];

    [Fact]
    public void Test_SearchThrowNotFoundException()
    {
        CitySearcher citySearcher = new CitySearcher(_testCities);
        Assert.Throws<NotFoundException>(() => citySearcher.SearchCities("a"));
    }
    
    [Theory]
    [InlineData("Va")]
    [InlineData("Val")]
    [InlineData("Pa")]
    [InlineData("va")]
    public void Test_SearchResultsStartWithExactChar(string search)
    {
        CitySearcher citySearcher = new CitySearcher(_testCities);
        List<string> results = citySearcher.SearchCities(search);
        Assert.True(
            results.TrueForAll(
                city => city.StartsWith(search, StringComparison.Ordinal)));
    }
}