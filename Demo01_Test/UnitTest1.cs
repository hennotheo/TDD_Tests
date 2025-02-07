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
        "Tokyo"
    ];
    
    [Theory]
    [InlineData("a")]
    public void Test_SearchThrowNotFoundException(string search)
    {
        CitySearcher citySearcher = new CitySearcher(_testCities);
        Assert.Throws<NotFoundException>(() => citySearcher.SearchCities(search));
    }
}