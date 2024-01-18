// See https://aka.ms/new-console-template for more information

using CustomCollection;

CustomCollection<int> customCollection = new CustomCollection<int>();
customCollection.Add(5);
customCollection.Add(1);
customCollection.Add(2);
customCollection.Add(52);
customCollection.Add(4);
foreach (int item in customCollection)
{
    Console.WriteLine(item);
}
