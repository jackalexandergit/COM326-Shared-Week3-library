using Library;

// lists
List<Book> books = new List<Book>();
List<Member> members = new List<Member>();

// add book objects
books.Add(new Book("C# for beginners","BillGates","12345678"));
books.Add(new Book("C# Methods and classes","Microsoft","55667778"));

// add member objects
members.Add(new Member(1, "John Smith", "1 High Street", 0790090090));
members.Add(new Member(2, "Mary Jones", "102 Garden Road", 0790345666));

// display items within book list
foreach (Book book in books)
{
    book.DisplayInfo();
}

// display items within member list
foreach (Member member in members)
{
    member.DisplayInfo();
}

// create a dictionary to track book inventory by ISBN
Dictionary<string, int> bookInventory = new Dictionary<string, int>();

// add our two sample books to the inventory (ISBN, Quantity)
bookInventory.Add("1234567", 5);
bookInventory.Add("2233445", 2);

// display the inventory for a specific book using its ISBN key
Console.WriteLine($"Copies of 'C# for beginners' in stock: {bookInventory["1234567"]}");

// attempt to access a book that does not exist in inventory
Console.WriteLine("Checking inventory for a missing book...");

try
{
    // This ISBN does not exist, so it will throw a KeyNotFoundException
    Console.WriteLine(bookInventory["9999999"]);
}
catch (Exception ex)
{
    Console.WriteLine("Error: That ISBN was not found in the inventory system.");
}
finally
{
    Console.WriteLine("Inventory check complete.");
}