public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<string> Comments { get; set; } = new List<string>();

    public string GetTitle() => Title;
    public string GetAuthor() => Author;
    public int GetLength() => Length;
    public int GetNumberOfComments() => Comments.Count;
    public void AddComment(string comment) => Comments.Add(comment);
    public List<string> GetComments() => Comments;
}