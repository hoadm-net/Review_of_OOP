namespace ObjectCollaborationExample;

public class Library
{
    private List<Book> Books = new List<Book>();

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public Book LendBook(string title)
    {
        var book = Books.Find(b => b.Title == title);
        if (book != null)
        {
            Books.Remove(book);
            return book;
        }
        return null;
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Books in Library:");
        foreach (var book in Books)
        {
            book.DisplayInfo();
        }
    }
}