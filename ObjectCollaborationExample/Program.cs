namespace ObjectCollaborationExample;

class Program
{
    static void Main(string[] args)
    {
        Author author1 = new Author("J.K. Rowling", "Famous for Harry Potter");
        Author author2 = new Author("George Orwell", "Famous for 1984");
        
        Book book1 = new Book("Harry Potter", author1);
        Book book2 = new Book("1984", author2);
        
        Library library = new Library();
        library.AddBook(book1);
        library.AddBook(book2);
        
        library.DisplayBooks();
        Console.WriteLine("------------------------");
        
        Member student = new StudentMember { Name = "Alice" };
        Member regularMember = new RegularMember { Name = "Bob" };
        
        student.BorrowBook(library, "Harry Potter");
        regularMember.BorrowBook(library, "The Great Gatsby"); // This book is not available

        Console.WriteLine();
        library.DisplayBooks();
    }
}