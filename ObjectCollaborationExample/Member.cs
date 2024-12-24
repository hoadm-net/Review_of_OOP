namespace ObjectCollaborationExample;

public abstract class Member
{
    public string Name { get; set; }
    public abstract void BorrowBook(Library library, string bookTitle);
}