namespace Demo01_Core;

public class NotFoundException : Exception
{
    public NotFoundException(string message) : base(message) { }
    public NotFoundException() : base("") { }
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
        throw new NotImplementedException();
    }
}