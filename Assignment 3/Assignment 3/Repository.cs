using Assignment_3.Interfaces;


namespace Assignment_3;

public class Repository : IRepository
{
    private readonly ILogger _logger;

    public Repository(ILogger logger)
    {
        _logger = logger;
    }

    public string GetData()
    {
        _logger.Log("getting data from repository.");
        return "data from repository";
    }
}