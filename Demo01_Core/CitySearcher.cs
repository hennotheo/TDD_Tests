namespace Demo01_Core;

public class NotFoundException : Exception
{
    public NotFoundException(string message) : base(message) { }
    public NotFoundException() : base("Not found exception") { }
}

public class CitySearcher
{
    private List<string> _cities;
    
    public CitySearcher(IEnumerable<string> cities)
    {
        _cities = new List<string>(cities);
    }
    
    public List<string> SearchCities(string search)
    {
        if(search.Length < 2)
        {
            throw new NotFoundException("Search string must be at least 2 characters long.");
        }

        throw new NotImplementedException();
    }
}