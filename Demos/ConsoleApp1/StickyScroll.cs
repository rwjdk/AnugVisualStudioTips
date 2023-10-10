using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
internal class StickyScroll
{
    private int _field1;
    private int _field2;
    private int _field3;

    public void LongMethod()
    {
        int x = 0;
        Console.WriteLine("Hello World");
        IEnumerable<object> myList = new List<string>
        {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
            "Item 5",
            "Item 6",
            "Item 7",
            "Item 8",
            "Item 9",
            "Item 10",
        };
        foreach (var item in myList) {
            Console.WriteLine(item);
        }
    }
}