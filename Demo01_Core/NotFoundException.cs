namespace Demo01_Core;

public class NotFoundException : Exception
{
    public NotFoundException(string message) : base(message) { }
    public NotFoundException() : base("Not found exception") { }
}