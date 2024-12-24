namespace ObjectCollaborationExample;

public class StudentMember : Member
{
    public override void BorrowBook(Library library, string bookTitle)
    {
        Console.WriteLine($"{Name} (Student) is borrowing the book: {bookTitle}");
        
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