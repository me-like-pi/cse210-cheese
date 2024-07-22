public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();

    public string GetTitle() => Title;
    public string GetAuthor() => Author;
    public int GetLength() => Length;
    public int GetNumberOfComments() => Comments.Count;
    public void AddComment(string commenterName, string commenterText) 
    {
        Comments.Add(new Comment { CommenterName = commenterName, CommenterText = commenterText });
    }
    public List<Comment> GetComments() => Comments;
}