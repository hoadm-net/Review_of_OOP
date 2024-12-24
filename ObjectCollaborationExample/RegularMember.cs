namespace ObjectCollaborationExample;

public class RegularMember : Member
{
    public override void BorrowBook(Library library, string bookTitle)
    {
        Console.WriteLine($"{Name} (Regular Member) is borrowing the book: {bookTitle}");
        var book = library.LendBook(bookTitle);
        if (book != null)
        {
            Console.WriteLine($"Borrowed successfully: {book.Title}");
        }
        else
        {
            Console.WriteLine($"The book '{bookTitle}' is not available.");
        }
    }
}