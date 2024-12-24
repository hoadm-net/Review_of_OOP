namespace ObjectCollaborationExample;

public class Author
{
    public string Name { get; set; }
    public string Bio { get; set; }

    public Author(string name, string bio)
    {
        Name = name;
        Bio = bio;
    }
}