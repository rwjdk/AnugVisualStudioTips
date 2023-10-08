// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var test = new Test();
test.Foo("Hello");
test.Foo("World");
test.Foo("42");

List<Car> cars = new List<Car>();
for (int i = 0; i < 20; i++)
{
    cars.Add(new Car()
    {
        Name = i.ToString(),
        NumberOfWheels = i.ToString(),
        MyGuid = Guid.NewGuid(),
    });
}

int debug = 0;

public class Test
{
    public void Foo(string input)
    {

    }
}

public class Car
{
    public string Name { get; set; }
    public string NumberOfWheels { get; set; }
    public Guid MyGuid { get; set; }
}