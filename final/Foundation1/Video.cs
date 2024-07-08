using System.Runtime.CompilerServices;


public class Video
{
    private string _title;
    private string _author;
    private float _length;
    private List<string> _comments;

    public Video()
    {
        _title = "Youtube test title";
        _comments = ["testlist","testlist 2"];
        _author = "melikepi";
        _length = 45.30f;
    }
    public string getTitle()
    {
        Console.WriteLine(_title);
        return _title;
    }
    public string getAuthor()
    {
        return _author;
    }
    public float getLength()
    {
        return _length;
    }
    public int getNumberOfComments()
    {
        return 66;
    }
    public void addComment()
    {
        
    }
    public List<string> getComments()
    {
        return _comments;
    }
}