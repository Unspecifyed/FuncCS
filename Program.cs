using FuncCS;

Console.WriteLine("Hello, World!");

static int triple(int x) => x * 3;
var range = Enumerable.Range(1, 3);
var triples = range.Select(triple);

Console.WriteLine(string.Join(", ", triples)); // Displaying the values in the triples collection
Console.WriteLine("asdfasdfasd");

var isOdd = (int x_) => x_% 2==1;
int[] original = {7,6,1 };
var sorted = original.OrderBy(x => x);

Console.WriteLine(string.Join(", ", sorted));

var filtered = sorted.Where(isOdd);
Console.WriteLine(string.Join(", ", filtered));

Console.WriteLine(string.Join(", ",
    Enumerable.Range(1,100).
    Where(i=> i % 20 == 0).
    OrderBy(i=> -i).
    Select(i=> $"{i}%")));

Console.WriteLine($"circle area: {new Circle(5).Area}");
