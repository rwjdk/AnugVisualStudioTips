namespace ClassLibrary;

public class Class1
{
    public async Task Foo()
    {
        var httpClient = new HttpClient();
        HttpResponseMessage response = await httpClient.GetAsync("https://www.google.com");
        Stream stream = await response.Content.ReadAsStreamAsync();
        //??? to String
        Bar("Hello");

    }

    public void Bar(string input)
    {
        Math.Round(1.23354, 2);
        var x = new HttpClient();
    }

    public int MyProperty { get; set; }
    public int MyProperty1 { get; private set; }
}
