namespace ObjectCollaborationExample;

public class Book
{
    public string Title { get; set; }
    public Author Author { get; private set; } // Composition

    public Book(string title, Author author)
    {
        Title = title;
        Author = author;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Book: {Title}, Author: {Author.Name}");
    }
}