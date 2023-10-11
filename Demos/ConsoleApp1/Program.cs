// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var test = new Test();
test.Foo("Hello");
test.Foo("World");
test.Foo("42");

List<Car> cars = new List<Car>();
for (int i = 0; i < 20; i++)
{
    var car = new Car()
    {
        Name = $"Car #{i}",
        NumberOfWheels = 4,
        MyGuid = Guid.NewGuid(),
    };
    cars.Add(car);
}

if(1==1)
{
    if(2==2)
    {
        if(3==3)
        {
            if(4==4)
            {
                //do stuff
            }
        }
    }
    else
    {
        //do stuff
    }
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
    public int NumberOfWheels { get; set; }
    public Guid MyGuid { get; set; }

    /// <summary>
    /// Start the car
    /// </summary>
    public void Start()
    {
        //Wroom, Wroom
    }
}