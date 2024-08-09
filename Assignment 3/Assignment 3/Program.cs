namespace Assignment_3;


using Assignment_3.Interfaces;


public class Program
{
    public static void Main()
    {
        var container = new IoCContainer();

        
        container.Register<ILogger, ConsoleLogger>();
        
        
        container.Register<IRepository, Repository>();
        
        
        container.Register<Service, Service>();


        var service = container.Resolve<Service>();

        
        service.Serve();
    }
}