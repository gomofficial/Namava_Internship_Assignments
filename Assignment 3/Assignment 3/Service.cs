using Assignment_3.Interfaces;


namespace Assignment_3;


public class Service
{
    private readonly IRepository _repository;

    public Service(IRepository repository)
    {
        _repository = repository;
    }

    public void Serve()
    {
        var data = _repository.GetData();
        Console.WriteLine($"service received: {data}");
    }
}