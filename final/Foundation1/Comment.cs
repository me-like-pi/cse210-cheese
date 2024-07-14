public class Comment
{
    public string CommenterName { get; set; }
    public string CommenterText { get; set; }

    public string GetCommenterName() => CommenterName;
    public string GetCommentText() => CommenterText;
}