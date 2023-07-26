var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Run();

record Customer(Guid Id, string FullName);

class CustomerRepository
{
        
}


