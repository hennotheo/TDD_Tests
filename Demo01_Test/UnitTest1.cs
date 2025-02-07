﻿using Demo01_Core;

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
    [InlineData("Va", "Vancouver", "Valencia")]
    [InlineData("Val", "Valencia")]
    [InlineData("Pa", "Paris")]
    public void Test_SearchResultsStartWithExactChar(string search, params string[] expectedResults)
    {
        CitySearcher citySearcher = new CitySearcher(_testCities);
        List<string> results = citySearcher.SearchCities(search);
        List<string> expected = new List<string>(expectedResults);

        Assert.Equal(expected.Count, results.Count);
    }

    [Theory]
    [InlineData("Va", "Vancouver", "Valencia")]
    [InlineData("VA", "Vancouver", "Valencia")]
    [InlineData("va", "Vancouver", "Valencia")]
    public void Test_SearchResultsCaseInsensitive(string search, params string[] expectedResults)
    {
        CitySearcher citySearcher = new CitySearcher(_testCities);
        List<string> results = citySearcher.SearchCities(search);
        List<string> expected = new List<string>(expectedResults);

        Assert.Equal(expected.Count, results.Count);
    }
}