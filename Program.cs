
Console.WriteLine("Hello, World!");

static int triple(int x) => x * 3;
var range = Enumerable.Range(1, 3);
var triples = range.Select(triple);

Console.WriteLine(string.Join(", ", triples)); // Displaying the values in the triples collection
Console.WriteLine("asdfasdfasd");
