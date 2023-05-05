// See https://aka.ms/new-console-template for more information
using IntegrationProject.Models;
using IntegrationProject.Services;

var people = new List<FakePerson>();
var service = new FakePersonService();

for (int i = 0; i < 2; i++)
{
    people.Add(service.Generate());
}


foreach (var p in people)
{
    Console.WriteLine($"{p.FirstName} {p.LastName}");
}

Console.ReadLine();
