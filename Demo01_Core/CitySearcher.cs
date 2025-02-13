﻿namespace Demo01_Core;

public class CitySearcher
{
    private readonly List<string> _cities;
    
    public CitySearcher(IEnumerable<string> cities)
    {
        _cities = new List<string>(cities);
    }
    
    public List<string> SearchCities(string search)
    {
        if(search == "*")
            return _cities;
        
        if(search.Length < 2)
            throw new NotFoundException("Search string must be at least 2 characters long.");

        return _cities.FindAll(
            (city) => city.Contains(search, StringComparison.CurrentCultureIgnoreCase));
    }
}